using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using WebApi.Models;

namespace WebApi.Controllers
{   
        public class HomeController : Controller
        {
            private readonly ILogger<HomeController> _logger;
            private readonly ISingletonHttp _isingletonhttp;

        public HomeController(ILogger<HomeController> logger, ISingletonHttp isingetonhttp)
        {
            _logger = logger;
            _isingletonhttp = isingetonhttp;
        }

        public IActionResult Index()
            {
                return View();
            }

            public async Task<IActionResult> GetCountry()
            {
                var response = await _isingletonhttp.GetServices();
                return View(response);
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }