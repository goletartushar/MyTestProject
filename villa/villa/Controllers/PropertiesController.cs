using Microsoft.AspNetCore.Mvc;

namespace villa.Controllers
{
    public class PropertiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
