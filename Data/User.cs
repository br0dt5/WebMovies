using Microsoft.AspNetCore.Identity;
using WebMovies.Models;

namespace WebMovies.Data
{
    public class User : IdentityUser
    {
        [PersonalData]
        public string? FullName { get; set; }
        public string? ProfilePicture { get; set; }
        public string? AboutMe { get; set; }
        public List<Movie> FavMovies { get; set; } = new List<Movie>();
        public List<Movie> Watchlist { get; set; } = new List<Movie>();
        public List<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
