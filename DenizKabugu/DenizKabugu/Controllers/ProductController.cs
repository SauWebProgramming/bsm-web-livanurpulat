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
                new Category(){CategoryID=1, Name="Cicek"},
                new Category(){CategoryID=2, Name="Cikolata"},
                new Category(){CategoryID=3, Name="Kitap"},
                new Category(){CategoryID=4, Name="Oyuncak"}
            };
            return View(categories);
        }

        public IActionResult Cicek()
        {
            var categories = new List<Category>()
            {
                new Category(){CategoryID=1, Name="Gül", },
                new Category(){CategoryID=2, Name="Papatya"},
                new Category(){CategoryID=3, Name="Karanfil"},
                new Category(){CategoryID=4, Name="Lale"}
            };
            return View(categories);
        }

        public IActionResult Cikolata()
        {
            var categories = new List<Category>()
            {
                new Category(){CategoryID=1, Name="Sütlü Çikolata"},
                new Category(){CategoryID=2, Name="Bitter Çikolata"},
                new Category(){CategoryID=3, Name="Beyaz Çikolata"},
            };
            return View(categories);
        }

        public IActionResult Oyuncak()
        {
            var categories = new List<Category>()
            {
                new Category(){CategoryID=1, Name="Puzzle"},
                new Category(){CategoryID=2, Name="Oyuncak Ayı"},
                new Category(){CategoryID=3, Name="Oyun Seti"},
            };
            return View(categories);
        }

        public IActionResult Kitap()
        {
            var categories = new List<Category>()
            {
                new Category(){CategoryID=1, Name="Simyacı"},
                new Category(){CategoryID=2, Name="Fareler ve İnsanlar"},
            };
            return View(categories);
        }

    }
}
