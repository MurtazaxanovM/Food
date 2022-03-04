using Food.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            ViewData["ComName"] = "RTM Margilan";
            ViewBag.Header = "Discover Restuarant And Food";

            List<FoodModel> food = new List<FoodModel>()
            {
                new FoodModel()
                {
                    Id =1,
                    Name = "Breakfast",
                    Image = "~/images/r1.jpg"
                },

                new FoodModel()
                {
                    Id =1,
                    Name = "Breakfast",
                    Image = "~/images/r2.jpg"
                },

                new FoodModel()
                {
                    Id =1,
                    Name = "Breakfast",
                    Image = "~/images/r3.jpg"
                },

                new FoodModel()
                {
                    Id =1,
                    Name = "Breakfast",
                    Image = "~/images/r1.jpg"
                },

                new FoodModel()
                {
                    Id =1,
                    Name = "Breakfast",
                    Image = "~/images/r2.jpg"
                },

                new FoodModel()
                {
                    Id =1,
                    Name = "Breakfast",
                    Image = "~/images/r3.jpg"
                }
            };
            return View(food);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Testimonial()
        {
            return View();
        }
    }
}
