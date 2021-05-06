using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PriceCalculator.DTO;
using PriceCalculator.Logic;
using PriceCalculator.Logic.Contracts;

namespace PriceCalculator.Controllers
{
    public class Login : Controller
    {
        IConfiguration config;
        ILoginLogic loginLogic;
        public Login(IConfiguration configuration, ILoginLogic loginLogic)
        {
            this.config = configuration;
            this.loginLogic = loginLogic;

        }
        public IActionResult Index()
        {
            return View("_login");
        }

        public IActionResult ValidateUser(LoginDTO input)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (string.IsNullOrEmpty(input.UserName) && string.IsNullOrEmpty(input.Password))
                    {
                        throw new Exception("UserName or Password missing");
                    }
                    input.Configurations = this.config;
                    var _loginResult = loginLogic.ValidateLogin(input);
                    if (_loginResult != null)
                    {
                        return RedirectToAction("LoadSales", "Sales", _loginResult);
                    }
                    ViewBag.LoginError = "User Name or Password incorrect";
                    return View("_login");
                }
                return View("_login",input);

            }
            catch(Exception ex)
            {
                return View("Error","Home");
            }
        }
    }
}
