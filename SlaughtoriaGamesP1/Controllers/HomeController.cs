using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SlaughtoriaGamesP1.Models;
using SlaughtoriaGamesP1.Data;
using Microsoft.Extensions.Caching.Memory;

namespace SlaughtoriaGamesP1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SGDB2Context _db;
        private IMemoryCache _cache;

        public HomeController(SGDB2Context db, IMemoryCache cache)
        {
            _db = db;
            _cache = cache;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
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
