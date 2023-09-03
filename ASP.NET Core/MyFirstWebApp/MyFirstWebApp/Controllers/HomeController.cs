using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Data;
using MyFirstWebApp.Models;
using MyFirstWebApp.ViewModels.Home;
using System.Diagnostics;

namespace MyFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext dbContext;

        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        public IActionResult Index(int id)
        {
            var viewModel = new IndexViewModel
            {
                Id = id,
                Name = "Mus",
                Year = DateTime.UtcNow.Year,
                ProcessorCount = Environment.ProcessorCount,
                UsersCount = dbContext.Users.Count()
            };

            return View(viewModel);
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