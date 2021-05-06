using Microsoft.Extensions.Configuration;
using PriceCalculator.DTO;
using PriceCalculator.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCalculator.Logic
{   
    public class LoginLogic : ILoginLogic
    {
        public LoginLogic()
        {

        }

        public UserDTO ValidateLogin(LoginDTO input)
        {
            var _users = input.Configurations.GetSection("Users").Get<List<LoginModel>>();

            if(_users.Any(x=>x.UserName == input.UserName && x.Password == input.Password))
            {
                var _user = _users.Where(x => x.UserName == input.UserName && x.Password == input.Password).FirstOrDefault();

                return new UserDTO()
                {
                    UserName = _user.UserName,
                    Previledge = _user.Previledge
                };
            }
            return null;
            
        }
    }
}
