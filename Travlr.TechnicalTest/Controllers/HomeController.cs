using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Travlr.TechnicalTest.Applications.Interfaces;
using Travlr.TechnicalTest.Models;

namespace Travlr.TechnicalTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISearchRepository _search;

        public HomeController(ILogger<HomeController> logger, ISearchRepository search, IMemoryCache cache)
        {
            _logger = logger;
            _search = search;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SearchResult(string keyword, string latitude, string longitude)
        {
            //var searchResult = await _search.Search("sky dive", -8.6969457, 115.2167603);
            var searchResult = await _search.Search(keyword, latitude, longitude);
            return View(searchResult);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
