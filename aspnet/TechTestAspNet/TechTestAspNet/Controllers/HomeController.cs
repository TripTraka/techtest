using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TechTestAspNet.Models;
using TechTestAspNet.Services;

namespace TechTestAspNet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICruiseService _cruiseService;

    public HomeController(ILogger<HomeController> logger, ICruiseService cruiseService)
    {
        _logger = logger;
        _cruiseService = cruiseService;
    }

    public async Task<IActionResult> Index()
    {
        var response = await _cruiseService.LoadJsonAsync();

        if (response == null || !response.Success || response.Data?.Cruises == null)
        {
            _logger.LogError("Failed to load cruise data.");
            return View(new List<Cruise>());
        }

        return View(response.Data.Cruises);
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
