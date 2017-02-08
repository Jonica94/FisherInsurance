using Microsoft.AspNetCore.Mvc;
using System;
namespace FisherInsurance.Models{
public class HomesController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the HomesController");
        return View();
    }
    public IActionResult Quote()
    {
        //return Ok("This is the quote of the HomesController");
        Quote quote = new Quote
         {
           Id = 345,
           Product = "Home Insurance",
           ExpireDate = DateTime.Now.AddDays(45),
           Price = 45.00M
       };
       return View(quote);
    }
}
}