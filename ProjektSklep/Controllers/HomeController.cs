using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjektSklep.Models;

namespace ProjektSklep.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //ostateczna metoda Index()
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //mockupowa metoda
        public IActionResult Index()
        {
            ViewBag.produkty = new List<Product>();
            Product p = new Product();
            p.Name = "Samochód";
            p.Price = 50;
            ViewBag.produkty.Add(p);
            Product p1 = new Product();
            p1.Name = "Samochód1";
            p1.Price = 78000;
            ViewBag.produkty.Add(p1);
            Product p2 = new Product();
            p2.Name = "Samochód2";
            p2.Price = 2137.99;
            ViewBag.produkty.Add(p2);
            Product p3 = new Product();
            p3.Name = "Komputer";
            p3.Price = 21378.99;
            ViewBag.produkty.Add(p3);
            Product p4 = new Product();
            p4.Name = "Samochód2";
            p4.Price = 420.99;
            ViewBag.produkty.Add(p4);

            ViewBag.kategorie = new List<Category>();
            Category c = new Category();
            c.Name = "Komputery";
            Category c1 = new Category();
            c1.Name = "Samochody";
            Category c2 = new Category();
            c2.Name = "Ludzie";

            ViewBag.kategorie.Add(c);
            ViewBag.kategorie.Add(c1);
            ViewBag.kategorie.Add(c2);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
