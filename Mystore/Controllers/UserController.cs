using Microsoft.AspNetCore.Mvc;

namespace Mystore.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
