using Microsoft.AspNetCore.Mvc;

namespace Retribusi.Controllers;

public class TpsController : Controller
{
    [HttpGet("/transport/tps")]
    public IActionResult Index()
    {
        return View("~/Views/Transport/Tps/Index.cshtml");
    }
}
