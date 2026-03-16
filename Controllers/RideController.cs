using Microsoft.AspNetCore.Mvc;
using GIT_Practice.Data;
using GIT_Practice.Models;

namespace GIT_Practice.Controllers
{
    public class RideController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RideController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Show booking form
        public IActionResult BookRide()
        {
            return View();
        }

        // Save ride booking
        [HttpPost]
        public IActionResult BookRider(RideBooking ride)
        {
            if (ModelState.IsValid)
            {
                _context.RideBookings.Add(ride);
                _context.SaveChanges();

                return RedirectToAction("Success");
            }

            // If validation fails return to booking form
            return View("BookRide", ride);
        }

        // Success page
        public IActionResult Success()
        {
            return View();
        }
    }
}