namespace WebMovies.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int MovieId { get; set; }
        public float Score { get; set; }
    }
}
