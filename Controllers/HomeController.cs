using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using WebApi.Models;

namespace WebApi.Controllers
{   
        public class HomeController : Controller
        {
            private readonly ILogger<HomeController> _logger;
            private readonly IConfiguration _iconfiguration;
      

        public HomeController(ILogger<HomeController> logger , IConfiguration iconfiguration)
            {
                _logger = logger;
                _iconfiguration = iconfiguration;
            }

            public IActionResult Index()
            {
                return View();
            }

            public async Task<IActionResult> GetCountry()
            {
                HttpClient client = new HttpClient();
                string strTestUrl = _iconfiguration.GetSection("ApiUrls").GetSection("CountryUrls").Value;
                using HttpResponseMessage response = await client.GetAsync(strTestUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<Country>>(responseBody);
                return View(data);
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }