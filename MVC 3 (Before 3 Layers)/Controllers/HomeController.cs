using Microsoft.AspNetCore.Mvc;

namespace MVC_3__Before_3_Layers_.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult AboutUs()
		{
			return View();
		}
		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult ContactUs()
		{
			return View();
		}
	}
}
