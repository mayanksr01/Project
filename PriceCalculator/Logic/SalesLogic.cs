using PriceCalculator.DTO;
using PriceCalculator.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCalculator.Logic
{
    public class SalesLogic : ISalesLogic
    {
        public double? CalculateDiscountedPrice(SalesDTO input)
        {
            var result = (input.Weight * input.PricePerGram);
            return result * input.Discount / 100;
        }

        public double CalculatePrice(SalesDTO input)
        {
            return (input.Weight * input.PricePerGram);
        }
    }
}
