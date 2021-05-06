using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCalculator.DTO
{
    public class LoginDTO : BaseDTO
    {
        [Required(ErrorMessage = "Please enter name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
    }
}
