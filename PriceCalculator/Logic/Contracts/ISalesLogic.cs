using PriceCalculator.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCalculator.Logic.Contracts
{
    public interface ISalesLogic
    {

        double? CalculateDiscountedPrice(SalesDTO input);

        double CalculatePrice(SalesDTO input);
    }
}
