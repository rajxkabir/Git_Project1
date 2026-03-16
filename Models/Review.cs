namespace GIT_Practice.Models
{
    public class Review
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string Comment { get; set; }
        public int Rating { get; set; }  // Add this line
    }
}
