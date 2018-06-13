using Microsoft.AspNetCore.Mvc;


namespace Livraria.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
