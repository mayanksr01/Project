using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PriceCalculator.DTO;
using PriceCalculator.Logic.Contracts;


namespace PriceCalculator.Controllers
{
    public class SalesController : Controller
    {
        ISalesLogic _salesLogic;
        public SalesController(ISalesLogic salesLogic)
        {

            _salesLogic = salesLogic;
        }
        public IActionResult Index()
        {
            return View("_sales");
        }

        public IActionResult LoadSales(UserDTO input)
        {
            ViewBag.UserName = input.UserName;
            ViewBag.Preveledge = input.Previledge;

            return View("_sales");
        }

        public IActionResult Calculate(SalesDTO input)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (input.Discount != null && input.Discount > 0)
                    {
                        var calculatedPrice = _salesLogic.CalculateDiscountedPrice(input);
                        ViewBag.TotalPrice = calculatedPrice;
                        
                        return View("_result");
                    }
                    else
                    {
                        var calculatedPrice = _salesLogic.CalculatePrice(input);
                        ViewBag.TotalPrice = calculatedPrice;
                        return View("_result");
                    }
                }
                return View("_sales", input);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IActionResult PrintToFile(SalesDTO input)
        {
            try
            {
                double? price = 0;
                if (ModelState.IsValid)
                {
                    if (input.Discount != null && input.Discount > 0)
                    {
                        var calculatedPrice = _salesLogic.CalculateDiscountedPrice(input);
                        price = calculatedPrice;
                    }
                    else
                    {
                        var calculatedPrice = _salesLogic.CalculatePrice(input);
                        price = calculatedPrice;
                    }
                    ViewBag.TotalPrice = price;
                    var directory = Directory.GetCurrentDirectory();
                    directory = directory + "/Result.txt";
                    System.IO.File.AppendAllText(directory, "\n Total Price : " + price);
                    ViewBag.FileResult = 1;
                }
                return View("_result");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public IActionResult AlertResult(SalesDTO input)
        {
            try
            {

                double? price = 0;
                if (ModelState.IsValid)
                {
                    if (input.Discount != null && input.Discount > 0)
                    {
                        var calculatedPrice = _salesLogic.CalculateDiscountedPrice(input);
                        price = calculatedPrice;
                        ViewBag.Preveledge = "1";
                    }
                    else
                    {
                        var calculatedPrice = _salesLogic.CalculatePrice(input);
                        price = calculatedPrice;
                    }
                    ViewBag.TotalPrice = price;
                    ViewBag.Alert = 1;
                }
                return View("_sales");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
