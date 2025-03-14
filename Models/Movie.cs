using System.ComponentModel.DataAnnotations;

namespace WebMovies.Models;

public class Movie
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Synopsis { get; set; }
    public string? Genre { get; set; }
    public string? Director { get; set; }

    [DataType(DataType.Date)]
    public DateTime? ReleaseDate { get; set; }
    public string? Cast { get; set; }
    public string? Trailer { get; set; }
    public float Score { get; set; }
    public List<Rating> Ratings { get; set; } = [];
    public string? Poster { get; set; }
    public int Duration { get; set; }
    public string? Keywords { get; set; }
}