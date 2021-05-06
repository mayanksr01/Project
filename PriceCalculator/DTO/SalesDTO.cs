using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCalculator.DTO
{
    public class SalesDTO
    {
        [Required(ErrorMessage = "Please Price Per Gram")]
        public double PricePerGram { get; set; }

        [Required(ErrorMessage = "Please enter weight")]
        public double Weight { get; set; }

        public double TotalPrice { get; set; }

        public float? Discount { get; set; }

    }
}
