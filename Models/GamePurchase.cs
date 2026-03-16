namespace GIT_Practice.Models  // Exact namespace!
{
    public class GamePurchase
    {
        public int Id { get; set; }

        public required string UserEmail { get; set; }

        public required string GameEdition { get; set; }
    }
}