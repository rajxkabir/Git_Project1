using Microsoft.AspNetCore.Mvc;

namespace GIT_Practice.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult BuyGame()
        {
            return View();
        }
    }
}