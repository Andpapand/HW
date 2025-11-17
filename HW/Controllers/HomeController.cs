using System.Diagnostics;
using HW.Models;
using HW.Services;
using Microsoft.AspNetCore.Mvc;

namespace HW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMessageService _service;

        public HomeController(ILogger<HomeController> logger, IMessageService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Intro()
        {
            return View();
        }

        public IActionResult Razor()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult IoC()
        {
            var model = new HomeIocViewModel
            {
                ControllerHash = _service.GetHashCode(),
                Message = _service.GetMessage()
            };

            return View(model);
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
