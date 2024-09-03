using Microsoft.AspNetCore.Mvc;

namespace MVC_3__Before_3_Layers_.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}
		public IActionResult Register()
		{
			return View();
		}
	}
}
