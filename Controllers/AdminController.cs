using Microsoft.AspNetCore.Mvc;
using GIT_Practice.Data;

namespace GIT_Practice.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}