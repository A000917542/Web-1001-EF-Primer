using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_1001_EF_Primer.Models;
using Web_1001_EF_Primer.Web_1001_EF_Primer.Data;

namespace Web_1001_EF_Primer.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly BlogContext _db;

    public HomeController(ILogger<HomeController> logger, BlogContext context)
    {
        _logger = logger;
        _db = context;
    }

    public IActionResult Index()
    {
        var posts = _db.Posts.ToList();
        return View(posts);
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
