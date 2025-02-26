using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebMovies.Data;
using WebMovies.Models;

namespace WebMovies.Areas.Identity.Pages.Account.Manage
{
    public class UserPlaylistsModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationDbContext _context;

        public UserPlaylistsModel(UserManager<User> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public List<Movie> UserFavorites = [];
        public List<Movie> UserWatchlist = [];

        public async Task<IActionResult> OnGet()
        {
            var loggedUser = await _userManager.GetUserAsync(User);

            if (loggedUser == null)
            {
                return RedirectToPage("Index");
            }

            var user = await _context.Users.Where(u => u.Id == loggedUser.Id).Include(u => u.FavMovies).Include(u => u.Watchlist).FirstOrDefaultAsync();

            UserFavorites = user!.FavMovies;
            UserWatchlist = user!.Watchlist;

            return Page();
        }
    }
}
