using Microsoft.AspNetCore.Mvc;
using GIT_Practice.Data;
using GIT_Practice.Models;
using GIT_Practice.Services;

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
        public IActionResult BookCar(RideBooking ride)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Save booking in database
                    _context.RideBookings.Add(ride);
                    _context.SaveChanges();

                    Console.WriteLine("Booking saved successfully");

                    // Send email ONLY if database save succeeded
                    EmailService emailService = new EmailService();
                    bool emailStatus = emailService.SendBookingEmail(ride);

                    if (emailStatus)
                    {
                        Console.WriteLine("Email sent successfully");
                    }
                    else
                    {
                        Console.WriteLine("Email failed to send");
                    }

                    return RedirectToAction("Success", "Ride");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database Error: " + ex.Message);

                    // Do NOT send email if DB fails
                    ViewBag.Error = "Booking failed. Please try again.";

                    return View("BookRide", ride);
                }
            }

            return View("BookRide", ride);
        }
        // Success page
        public IActionResult Success()
        {
            return View();
        }
    }
}