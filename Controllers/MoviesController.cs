using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMovies.Data;
using WebMovies.Models;

namespace WebMovies.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public MoviesController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }

        // POST: Movies
        [HttpPost, ActionName("Index")]
        public async Task<IActionResult> Search(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
            {
                return RedirectToAction(nameof(Index));
            }

            return View(await _context.Movies
                                        .Where(m => m.Name!
                                        .ToLower()
                                        .Contains(searchString.ToLower()))
                                        .ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var user = await _userManager.GetUserAsync(User);

            return View(await _context.Movies
                                        .Where(m => m.Id == id)
                                        .FirstOrDefaultAsync());
        }

        [HttpPost, ActionName("Details")]
        public async Task<IActionResult> SaveToPlaylist(int id, string playlist)
        {
            var user = await _userManager.GetUserAsync(User);
            var movie = await _context.Movies
                                        .Where(m => m.Id == id)
                                        .FirstOrDefaultAsync();

            if (user == null || movie == null)
            {
                return RedirectToAction("Index");
            }

            if (playlist.Equals("Favorites"))
            {
                user.FavMovies.Add(movie);
            }
            else if (playlist.Equals("Watchlist"))
            {
                user.Watchlist.Add(movie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
