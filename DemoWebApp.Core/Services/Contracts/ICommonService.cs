using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.Services.Contracts
{
    public interface ICommonService
    {
        string Encrypt(string text);
        string Decrypt(string text);
        string GetRoleName(string code);
        int GetRoleDataLevel(string code);
        string GetParameter(string code);
    }
}
