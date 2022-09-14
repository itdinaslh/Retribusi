using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Retribusi.Controllers;

[Authorize]
public class WilayahController : Controller
{
    [HttpGet("/master/kabupaten")]
    public IActionResult Kabupaten()
    {
        return View("~/Views/Master/Kabupaten/Index.cshtml");
    }

    [HttpGet("/master/kecamatan")]
    public IActionResult Kecamatan()
    {
        return View("~/Views/Master/Kecamatan/Index.cshtml");
    }

    [HttpGet("/master/kelurahan")]
    public IActionResult Kelurahan()
    {
        return View("~/Views/Master/Kelurahan/Index.cshtml");
    }
}
