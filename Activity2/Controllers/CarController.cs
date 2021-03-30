using Activity2.Models;
using Activity2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            //create an instance of Mobility smaple data to access the method in order to have a link to the data & display
            // to the browser

            MobilitySampleData mobilitySampleData = new MobilitySampleData();

            return View(mobilitySampleData.GetAllCars());
        }
    }
}
