using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public interface IAuthService
    {
         Task<string> Authenticate(string phoneNumber, string code);
    }
}
