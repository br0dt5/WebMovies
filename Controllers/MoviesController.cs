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
            return View(await _context.Movies
                                        .Where(m => m.Name!
                                        .Contains(searchString, StringComparison.InvariantCultureIgnoreCase))
                                        .ToListAsync());
        }
    }
}
