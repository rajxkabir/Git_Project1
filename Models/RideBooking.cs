namespace GIT_Practice.Models  // Exact namespace!
{
    public class RideBooking
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Car { get; set; }

        public DateTime RideDate { get; set; } // from step 1 if you add it
    }
}