using Microsoft.AspNetCore.Identity;

namespace WebMovies.Data
{
    public class User : IdentityUser
    {
        [PersonalData]
        public string? FullName { get; set; }
    }
}
