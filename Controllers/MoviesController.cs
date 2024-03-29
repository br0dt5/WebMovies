using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
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

        public async Task<IActionResult> Details(int id)
        {
            return View(await _context.Movies
                                        .Where(m => m.Id == id)
                                        .FirstOrDefaultAsync());
        }
    }
}
