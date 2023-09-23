using Microsoft.AspNetCore.Mvc;

namespace Mystore.Controllers
{
    public class NutrionalProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
