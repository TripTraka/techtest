using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TechTestAspNet.Models;
using TechTestAspNet.Services;
using TechTestAspNet.Helpers;

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

    public async Task<IActionResult> Index(string? search)
    {
        var response = await _cruiseService.LoadJsonAsync();

        if (response == null || !response.Success || response.Data?.Cruises == null)
        {
            _logger.LogError("Failed to load cruise data.");
            return View(new List<Cruise>());
        }

        var cruises = response.Data.Cruises;

        if (!string.IsNullOrWhiteSpace(search))
        {
            search = search.Trim().ToLowerInvariant();
            cruises = cruises.Where(c =>
                (!string.IsNullOrEmpty(c.TripName) && c.TripName.ToLowerInvariant().Contains(search)) ||
                (!string.IsNullOrEmpty(c.EmbarkationPort) && c.EmbarkationPort.ToLowerInvariant().Contains(search)) ||
                (!string.IsNullOrEmpty(c.ItineraryName) && c.ItineraryName.ToLowerInvariant().Contains(search)) ||
                (!string.IsNullOrEmpty(c.Ship) && c.Ship.ToLowerInvariant().Contains(search)) ||
                (!string.IsNullOrEmpty(c.Terms) && c.Terms.ToLowerInvariant().Contains(search)) ||
                (!string.IsNullOrEmpty(c.Inclusions) && c.Inclusions.ToLowerInvariant().Contains(search)) ||
                (c.StartDate != null && DateHelper.FormatDate(c.StartDate).ToLowerInvariant().Contains(search))
            ).ToList();
        }

        ViewData["Search"] = search;
        return View(cruises);
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
