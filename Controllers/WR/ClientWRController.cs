using Microsoft.AspNetCore.Mvc;
using Retribusi.Repositories;
using Retribusi.Models;
using Retribusi.Entities;
using Microsoft.AspNetCore.Authorization;
using Retribusi.Helpers;

namespace Retribusi.Controllers;

[Authorize(Roles = "SysAdmin, WRAdmin")]
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

    [HttpGet("/wr/lokasi/create")]
    public IActionResult Create()
    {
        return PartialView("~/Views/WR/Client/AddEdit.cshtml", new CLientVM
        {
            ClientWR = new ClientWR()            
        });
    }

    [HttpPost("/wr/lokasi/store")]
    public async Task<IActionResult> Store(CLientVM model)
    {
        if (ModelState.IsValid)
        {
            await repo.SaveDataAsync(model.ClientWR);

            return Json(Result.Success());
        }

        return PartialView("~/Views/WR/Client/AddEdit.cshtml", model);
    }
}
