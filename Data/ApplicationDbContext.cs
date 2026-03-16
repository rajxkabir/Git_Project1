using Microsoft.EntityFrameworkCore;
using GIT_Practice.Models;

namespace GIT_Practice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<RideBooking> RideBookings { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<GamePurchase> GamePurchases { get; set; }
    }
}