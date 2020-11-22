using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using ProjektSklep.Data;
using ProjektSklep.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjektSklep.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ShoppingCart _shoppingCart;

        private readonly ShopContext _context;

        private readonly ILogger<HomeController> _logger;

        public ShoppingCartController(ILogger<HomeController> logger, ShopContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            _shoppingCart = CreateCart();
            return View(_shoppingCart);
        }

        private ShoppingCart CreateCart()
        {
            _shoppingCart = new ShoppingCart();
            _shoppingCart.ProductList = new List<ShoppingCartElement>();
            List<Product> products = _context.Products.Include(p => p.Category).Include(p => p.Expert).ToList();

            var cookie = Request.Cookies["ShoppingCart"];
            if (cookie != null)
            {
                string[] elements = cookie.Split('-');
                if (elements.Count() != 0)
                {
                    List<int> ids = new List<int>();
                    foreach (var item in elements)
                    {
                        if (item != "")
                            ids.Add(int.Parse(item));
                    }

                    foreach (int id in ids)
                    {
                        var elem = products.Find(x => x.ProductID == id);

                        if (elem != null)
                        {
                            var product = _shoppingCart.ProductList.Find(x => x.Product.ProductID == id);
                            if (product != null)
                            {
                                product.Count++;
                                product.Sum += elem.Price;
                            }
                            else
                            {
                                _shoppingCart.ProductList.Add(new ShoppingCartElement { Product = elem, Count = 1, Sum = elem.Price });
                            }
                        }
                    }
                }
            }
            return _shoppingCart;
        }

        [HttpGet("ShoppingCart/Index/{ProductID:int}")]
        public IActionResult Index(int? ProductID)
        {
            if (ProductID == null)
            {
                return NotFound();
            }

            _shoppingCart = CreateCart();
            var toRemove = _shoppingCart.ProductList.Find(x => x.Product.ProductID == ProductID);

            if(toRemove != null)
            {
                if (toRemove.Count > 1)
                {
                    toRemove.Count--;
                    toRemove.Sum -= toRemove.Product.Price;
                }
                else if (toRemove.Count == 1)
                {
                    toRemove.Count--;
                    toRemove.Sum -= toRemove.Product.Price;
                    _shoppingCart.ProductList.Remove(toRemove);
                }
            }

            UpdateCookies();
            return View(_shoppingCart);
        }

        [HttpGet("ShoppingCart/OrderCompleted")]
        public IActionResult OrderCompleted()
        {
            _shoppingCart = CreateCart();
            return View(_shoppingCart);
        }

        public void UpdateCookies()
        {
            string cookiesvalue = "";

            foreach (var p in _shoppingCart.ProductList)
            {
                for (int i = 0; i < p.Count; i++)
                {
                    cookiesvalue += $"-{p.Product.ProductID}";
                }
            }

            Response.Cookies.Append("ShoppingCart", cookiesvalue);
        }
    }
}
