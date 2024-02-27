namespace WebMovies.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Synopsis { get; set; }
    public string? Director { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public string? Cast { get; set; }
    public string? Keywords { get; set; }
}