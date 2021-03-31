using Activity2.Models;
using Activity2.Services;
using Bogus;
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
            ProductDAO products = new ProductDAO();
            
            return View(products.GetAllProducts());
        }

        public IActionResult searchResults(string search)
        {
            ProductDAO products = new ProductDAO();

            List<ProductModel> productList = products.SearchProducts(search);
            return View("index", productList);
        }

        public IActionResult searchForm()
        {
            return View();
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
