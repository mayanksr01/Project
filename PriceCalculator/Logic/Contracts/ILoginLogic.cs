using PriceCalculator.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCalculator.Logic.Contracts
{
    public interface ILoginLogic
    {
        UserDTO ValidateLogin(LoginDTO input);
    }
}
