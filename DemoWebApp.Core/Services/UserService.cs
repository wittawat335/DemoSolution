using AutoMapper;
using DemoWebApp.Core.Domain.Entities;
using DemoWebApp.Core.Domain.RepositoryContracts;
using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Helper;
using DemoWebApp.Core.Models;
using DemoWebApp.Core.Services.Contracts;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Ocsp;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DemoWebApp.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<M_USER> _repository;
        private readonly IGenericRepository<M_USER_ROLE> _userRoleRepository;
        private readonly IGenericRepository<T_CURRENT_LOGIN> _currentLoginRepository;
        private readonly IGenericRepository<T_LOGIN_HISTORY> _loginHistoryRepository;
        private readonly ICommonService _commonService;
        private readonly IMapper _mapper;
        private readonly JwtSettings _jwtSettings;

        public UserService(
            IGenericRepository<M_USER> repository,
            IGenericRepository<M_USER_ROLE> userRoleRepository,
            IGenericRepository<T_CURRENT_LOGIN> currentLoginRepository,
            IGenericRepository<T_LOGIN_HISTORY> loginHistoryRepository,
            ICommonService commonService,
            IMapper mapper,
            IOptions<JwtSettings> options
           )
        {
            _repository = repository;
            _userRoleRepository = userRoleRepository;
            _currentLoginRepository = currentLoginRepository;
            _loginHistoryRepository = loginHistoryRepository;
            _commonService = commonService;
            _jwtSettings = options.Value;
            _mapper = mapper;
        }

        public async Task<ResponseApi<List<UserDTO>>> GetAll()
        {
            var response = new ResponseApi<List<UserDTO>>();
            try
            {
                var list = await _repository.GetListAsync();
                if (list.Count() > 0)
                {
                    response.Value = _mapper.Map<List<UserDTO>>(list);
                    response.IsSuccess = true;
                    response.Message = "GetList Success";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<ResponseApi<UserDTO>> GetByUserLogin(string userLogin)
        {
            var response = new ResponseApi<UserDTO>();
            try
            {
                var user = await _repository.GetAsync(x => x.USER_LOGIN == userLogin);
                if (user != null)
                {
                    response.Value = _mapper.Map<UserDTO>(user);
                    response.IsSuccess = true;
                    response.Message = "Success";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<ResponseApi<LoginResponse>> Login(LoginRequest request)
        {
            var response = new ResponseApi<LoginResponse>();
            try
            {
                response = await CheckLogin(request);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ResponseApi<LoginResponse>> CheckLogin(LoginRequest request)
        {
            var response = new ResponseApi<LoginResponse>();
            try
            {
                var user = await _repository.GetAsync(x => x.USER_LOGIN == request.UserName);
                if (user != null && user.USER_STATUS == "A")
                {
                    request.Password = _commonService.Encrypt(request.Password);
                    if (user.USER_PASSWORD == request.Password)
                    {
                        response = await GenerateToken(user);
                        await InsertCurrentLogin(user, request.Ip);
                    }
                    else
                        response.Message = "invaild password";
                }
                else if (user != null && user.USER_STATUS == "I")
                    response.Message = "user is InActive";

                else
                    response.Message = "not found user";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public Task<ResponseApi<UserDTO>> Insert(UserDTO request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseApi<UserDTO>> Update(UserDTO request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseApi<UserDTO>> Delete(UserDTO request)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseApi<LoginResponse>> GenerateToken(M_USER user)
        {
            var response = new ResponseApi<LoginResponse>();
            var loginResponse = new LoginResponse();
            try
            {
                var claims = new List<Claim> {
                        new Claim(JwtRegisteredClaimNames.Sub, _jwtSettings.Subject),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", user.USER_LOGIN)
                    };
                var lastRoleLogin = _currentLoginRepository.AsQueryable(x => x.CL_USER_LOGIN == user.USER_LOGIN);
                var lastRole = lastRoleLogin.OrderByDescending(x => x.CL_LAST_ACT_DATE).FirstOrDefault();
                var roles = await _userRoleRepository.GetListAsync(x => x.USERROLE_USER_LOGIN == user.USER_LOGIN && x.USERROLE_STATUS == "A");
                var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x.USERROLE_ROLE_CODE));
                claims.AddRange(roleClaims);

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                   _jwtSettings.Issuer,
                   _jwtSettings.Audience,
                   claims,
                   expires: DateTime.UtcNow.AddMinutes(10),
                   signingCredentials: signIn);

                loginResponse.accessToken = new JwtSecurityTokenHandler().WriteToken(token);
                loginResponse.userLogin = user.USER_LOGIN;
                loginResponse.fullName = user.USER_FIRST_NAME + " " + user.USER_LAST_NAME;
                loginResponse.role = lastRole.CL_ROLE_CODE;
                loginResponse.roleName = _commonService.GetRoleName(lastRole.CL_ROLE_CODE);
                loginResponse.dataLevel = _commonService.GetRoleDataLevel(lastRole.CL_ROLE_CODE).ToString();

                response.Message = "Login Success";
                response.IsSuccess = true;
                response.Value = loginResponse;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<long> InsertCurrentLogin(M_USER user, string ip)
        {
            try
            {
                var query = await _currentLoginRepository.GetListAsync(x => x.CL_USER_LOGIN == user.USER_LOGIN);
                if (query != null)
                    _currentLoginRepository.DeleteList(query);

                var currentLogin = new T_CURRENT_LOGIN();
                currentLogin.CL_USER_LOGIN = user.USER_LOGIN;
                currentLogin.CL_ROLE_CODE = "";
                currentLogin.CL_IP_ADDRESS = ip;
                currentLogin.CL_LOGIN_DATE = DateTime.Now;
                currentLogin.CL_LAST_ACT_DATE = DateTime.Now;
                currentLogin.CL_STATUS = "A";

                var loginHistory = new T_LOGIN_HISTORY();
                loginHistory.CL_USER_LOGIN = user.USER_LOGIN;
                loginHistory.CL_ROLE_CODE = "";
                loginHistory.CL_IP_ADDRESS = ip;
                loginHistory.CL_LOGIN_DATE = DateTime.Now;
                loginHistory.CL_LAST_ACT_DATE = DateTime.Now;
                loginHistory.CL_STATUS = "A";

                await _currentLoginRepository.InsertAsync(currentLogin);
                await _loginHistoryRepository.InsertAsync(loginHistory);

                await _currentLoginRepository.SaveChangesAsync();
                await _loginHistoryRepository.SaveChangesAsync();

                return currentLogin.CL_ID;
            }
            catch
            {
                throw;
            }
        }
    }
}
