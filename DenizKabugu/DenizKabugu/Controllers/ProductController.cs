using DenizKabugu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DenizKabugu.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Product()
        {
            var categories = new List<Category>()
            {
                new Category(){CategoryID=1, Name="Çiçek"},
                new Category(){CategoryID=2, Name="Çikolata"},
                new Category(){CategoryID=3, Name="Kitap"},
                new Category(){CategoryID=4, Name="Oyuncak"}
            };
            return View(categories);
        }

        public IActionResult Cicek(Category cicek)
        {
            return View(cicek);
        }

        public IActionResult Cikolata()
        {
            return View();
        }

        public IActionResult Oyuncak()
        {
            return View();
        }

        public IActionResult Kitap()
        {
            return View();
        }

    }
}
