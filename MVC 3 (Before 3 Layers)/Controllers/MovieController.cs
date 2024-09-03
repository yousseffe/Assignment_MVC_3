using Microsoft.AspNetCore.Mvc;

namespace MVC_3__Before_3_Layers_.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult GetMovie(int id, string name)
        {
            return Content($"Movie with id : {id} and name : {name}", "text/html");
        }

        public IActionResult Index()
        {
            return RedirectToAction(nameof(GetMovie), new { id = 22 });
        }

        public ViewResult Hamada()
        {
            return View();
        }
    }
}
