using Microsoft.AspNetCore.Mvc;
using Retribusi.Repositories;

namespace Retribusi.Controllers;

public class ClientWRController : Controller
{
    private readonly IClientWR repo;

    public ClientWRController(IClientWR repo)
    {
        this.repo = repo;
    }

    [HttpGet("/wr/lokasi")]
    public IActionResult Index()
    {
        return View("~/Views/WR/Client/Index.cshtml");
    }
}
