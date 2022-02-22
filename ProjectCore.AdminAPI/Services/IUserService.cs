using ProjectCore.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.AdminAPI.Services
{
    public interface IUserService
    {
         Task<string> Login(LoginRequest request);
    }
}
