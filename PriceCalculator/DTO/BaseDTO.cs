using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCalculator.DTO
{
    public class BaseDTO
    {
        public IConfiguration Configurations { get; set; }
    }
}
