using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMovies.Data;
using WebMovies.Models;

namespace WebMovies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [BindProperty(SupportsGet = true)]
    public string SearchString { get; set; } = string.Empty;

    public IActionResult Index()
    {
        return View(_context.Movies.ToList());
    }

    public IActionResult Search()
    {
        return RedirectToAction("Search", "Movies", new { searchString = SearchString });
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
