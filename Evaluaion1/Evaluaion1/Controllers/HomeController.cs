using Evaluacion1;
using Evaluaion1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Evaluaion1.Controllers
{
    public class HomeController : Controller
    {
  
        public async Task<IActionResult> Index()
        {
            var service = new ServiceClient();
            var x = await service.GetUserAsync(int.MaxValue);
            return View(x); 
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