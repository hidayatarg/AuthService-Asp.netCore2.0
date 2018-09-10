using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPcoreAuth.API.Models;

namespace ASPcoreAuth.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string userName, string password);

        Task<bool> UserExits(string userName);
    }
}
