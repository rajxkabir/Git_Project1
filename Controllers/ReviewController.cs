using Microsoft.AspNetCore.Mvc;
using GIT_Practice.Data;
using GIT_Practice.Models;
using System.Linq;

namespace GIT_Practice.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Show all reviews
        public IActionResult RIndex()
        {
            var reviews = _context.Reviews.ToList();
            return View(reviews);
        }

        // Open review form
        public IActionResult Create()
        {
            return View();
        }

        // Save review
        [HttpPost]
        public IActionResult Create(Review review)
        {
            if (ModelState.IsValid)
            {
                _context.Reviews.Add(review);
                _context.SaveChanges();
                return RedirectToAction("RIndex");
            }

            return View(review);
        }
    }
}