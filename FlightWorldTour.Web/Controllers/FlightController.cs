using Microsoft.AspNetCore.Mvc;

namespace FlightWorldTour.Web.Controllers;

public class FlightController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}