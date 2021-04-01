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

        public IActionResult ShowDetails(int id)
        {
            ProductDAO products = new ProductDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View(foundProduct);
        }

        public IActionResult Edit(int id)
        {
            ProductDAO products = new ProductDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View("ShowEdit", foundProduct);
        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            ProductDAO products = new ProductDAO();
            products.Update(product);
            return View("Index", products.GetAllProducts());
        }

        public IActionResult Delete(int id)
        {
            ProductDAO products = new ProductDAO();
            ProductModel product = products.GetProductById(id);
            products.Delete(product);
            return View("Index", products.GetAllProducts());
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
