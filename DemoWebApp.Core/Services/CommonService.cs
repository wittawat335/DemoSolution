using DemoWebApp.Core.Domain.Entities;
using DemoWebApp.Core.Domain.RepositoryContracts;
using DemoWebApp.Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.Services
{
    public class CommonService : ICommonService
    {
        private readonly IGenericRepository<M_ROLE> _roleRepository;
        private readonly IGenericRepository<M_PARAMETER> _parameterRepository;

        public CommonService(
            IGenericRepository<M_ROLE> roleRepository,
            IGenericRepository<M_PARAMETER> parameterRepository
            )
        {
            _roleRepository = roleRepository;
            _parameterRepository = parameterRepository;
        }

        public string Decrypt(string text)
        {
            string encryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(text);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    text = Encoding.Unicode.GetString(ms.ToArray());
                }
            }

            return text;
        }

        public string Encrypt(string text)
        {
            string encryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(text);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    text = Convert.ToBase64String(ms.ToArray());

                }
            }

            return text;
        }

        public string GetParameter(string code)
        {
            return _parameterRepository.Get(x => x.PARA_CODE == code).PARA_VALUE;
        }

        public int GetRoleDataLevel(string code)
        {
            return _roleRepository.Get(x => x.ROLE_CODE == code).ROLE_DATA_LEVEL;
        }

        public string GetRoleName(string code)
        {
            return _roleRepository.Get(x => x.ROLE_CODE == code).ROLE_NAME;
        }
    }
}
