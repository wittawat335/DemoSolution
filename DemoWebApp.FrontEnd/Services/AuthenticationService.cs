
using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Models;
using DemoWebApp.FrontEnd.Services.Interfaces;
using DemoWebApp.FrontEnd.Utilities.AppSetting;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http;
using DemoWebApp.FrontEnd.Utilities;
using System.Net;

namespace DemoWebApp.FrontEnd.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IAppSeting _appSetting;
        HttpClientHandler _httpClient = new HttpClientHandler();
        public AuthenticationService(IAppSeting appSetting, IHttpContextAccessor contextAccessor)
        {
            _appSetting = appSetting;
            _httpClient.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            _contextAccessor = contextAccessor;
        }

        public string GetIp()
        {
            string ip = _contextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
            if (ip == "::1")
                ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            return ip;
        }

        public async Task<ResponseApi<LoginResponse>> Login(LoginRequest request)
        {
            var response = new ResponseApi<LoginResponse>();
            var path = _appSetting.BaseUrlApi + "User/Login";
            try
            {
                using (var client = new HttpClient(_httpClient))
                {
                    client.BaseAddress = new Uri(path);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage result = await client.PostAsJsonAsync<LoginRequest>(path, request);
                    if (result.IsSuccessStatusCode)
                    {
                        string data = result.Content.ReadAsStringAsync().Result;
                        response = JsonConvert.DeserializeObject<ResponseApi<LoginResponse>>(data);
                        SetSessionValue(response.Value);
                    }
                    else
                        response.Message = Constants.MessageError.CallAPI;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public void LogOut()
        {
            _contextAccessor.HttpContext.Session.Remove(Constants.SessionKey.sessionLogin);
            _contextAccessor.HttpContext.Session.Remove(Constants.SessionKey.accessToken);
        }

        public void SetSessionValue(LoginResponse response)
        {
            try
            {
                string sessionString = JsonConvert.SerializeObject(response);
                string tokenString = JsonConvert.SerializeObject(response.accessToken);
                if (sessionString != null)
                    _contextAccessor.HttpContext.Session.SetString(Constants.SessionKey.sessionLogin, sessionString);
                if (tokenString != null)
                    _contextAccessor.HttpContext.Session.SetString(Constants.SessionKey.accessToken, tokenString);
            }
            catch
            {
                throw;
            }
        }
    }
}
