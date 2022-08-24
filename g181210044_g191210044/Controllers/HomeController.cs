using g181210044_g191210044.Data;
using g181210044_g191210044.Entity;
using g181210044_g191210044.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace g181210044_g191210044.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Blog()
        {
            var model = new BlogPageViewModel
            {
                BlogYazilari = BlogYazisiRepository.BlogYazisis
            };

            return View(model);
        }
        public IActionResult Market()
        {
            return View();
        }
        public IActionResult Iletisim()
        {
            return View();
        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
