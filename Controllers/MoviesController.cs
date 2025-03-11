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

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; } = string.Empty;

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }

        public async Task<IActionResult> Search()
        {
            if (string.IsNullOrEmpty(SearchString))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                SearchString = SearchString.ToLower();
            }

            var results = _context.Movies.Where(m => m.Name.ToLower().Contains(SearchString) ||
                                                    m.Genre!.ToLower().Contains(SearchString) ||
                                                    m.Director!.ToLower().Contains(SearchString) ||
                                                    m.Cast!.ToLower().Contains(SearchString) ||
                                                    m.Synopsis!.ToLower().Contains(SearchString) ||
                                                    m.Keywords!.ToLower().Contains(SearchString))
                                        .ToListAsync();

            return View("Index", await results);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var user = await _userManager.GetUserAsync(User);

            return View(await _context.Movies
                                        .Where(m => m.Id == id)
                                        .FirstOrDefaultAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SaveToFavorites(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var movie = await _context.Movies
                                        .Where(m => m.Id == id)
                                        .FirstOrDefaultAsync();

            if (user == null || movie == null)
            {
                return RedirectToAction("Index");
            }

            user.FavMovies.Add(movie);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> SaveToWatchlist(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var movie = await _context.Movies
                                        .Where(m => m.Id == id)
                                        .FirstOrDefaultAsync();

            if (user == null || movie == null)
            {
                return RedirectToAction("Index");
            }

            user.Watchlist.Add(movie);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> AddRating(int id, int score)
        {
            var user = await _userManager.GetUserAsync(User);
            var movie = await _context.Movies
                                        .Where(m => m.Id == id)
                                        .Include(m => m.Ratings)
                                        .FirstOrDefaultAsync();

            if (user == null || movie == null)
            {
                return RedirectToAction("Index");
            }

            var rating = new Rating { Score = score };

            user.Ratings.Add(rating);
            movie.Ratings.Add(rating);

            movie.Score = movie.Ratings.Average(r => r.Score);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
