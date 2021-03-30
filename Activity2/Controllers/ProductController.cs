using Activity2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<ProductModel> productsList = new List<ProductModel>();

            productsList.Add(new ProductModel { Id = 1, Name = "Tomatoes", Price = 12.23m, Description = "Red cherry sweet tomatoes" });
            productsList.Add(new ProductModel { Id = 2, Name = "Mangoes", Price = 23.00m, Description = "Colorfoul mangoes" });
            productsList.Add(new ProductModel { Id = 3, Name = "Grapes", Price = 1.89m, Description = "Green grapes" });
            productsList.Add(new ProductModel { Id = 4, Name = "Strawberry", Price = 5.90m, Description = "Strawberries from Italy" });
            productsList.Add(new ProductModel { Id = 5, Name = "Apples", Price = 54.00m, Description = "South African Apples" });
            
            return View(productsList);
        }

        public IActionResult Message()
        {
            return View("message");
        }

        public IActionResult Welcome(string name, int secretNumber=100)
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;
            return View();
        }
    }
}
