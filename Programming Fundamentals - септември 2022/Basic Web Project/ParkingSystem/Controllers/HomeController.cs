using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParkingSystem.Data;
using ParkingSystem.Data.Models;
using System.Linq;

namespace ParkingSystem.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View(DataAccess.Cars);
		}

		[HttpPost]

		public IActionResult AddCar(Car car)
		{
			DataAccess.Cars.Add(car);

			return Redirect("/");
		}

        [HttpPost]

        public IActionResult DeleteCar(string plateNumber)
        {
			var car = DataAccess.Cars.FirstOrDefault(x => x.PlateNumber == plateNumber);
			DataAccess.Cars.Remove(car);

			return Redirect("/");

            
        }
    }

}