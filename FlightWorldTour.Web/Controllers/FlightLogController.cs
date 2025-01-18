using Microsoft.AspNetCore.Mvc;

namespace FlightWorldTour.Web.Controllers;

public class FlightLogController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}