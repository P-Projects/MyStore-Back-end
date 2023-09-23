using Microsoft.AspNetCore.Mvc;

namespace Mystore.Controllers
{
    public class NonNutrionalProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
