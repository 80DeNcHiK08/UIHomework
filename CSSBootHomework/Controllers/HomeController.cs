using Microsoft.AspNetCore.Mvc;

namespace CSSBootHomework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
