using System.Diagnostics;
using FlightWorldTour.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using FlightWorldTour.Web.Models;
using Microsoft.AspNetCore.Authorization;

namespace FlightWorldTour.Web.Controllers;

public class HomeController(
    ILogger<HomeController> logger,
    IFlightService flightService) : Controller
{
    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var lastFlightData = await flightService.GetLastFlightAsync();
        var homeViewModel = new HomePageViewModel
        {
            OriginAirportName = lastFlightData.OriginAirportName,
            OriginCountry = lastFlightData.OriginCountry,
            DestinationAirportName = lastFlightData.DestinationAirportName,
            DestinationCountry = lastFlightData.DestinationCountry
        };
        
        return View(homeViewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}