using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Retribusi.Entities;
using Retribusi.Repositories;
using Retribusi.Helpers;

namespace Retribusi.Controllers;

[Authorize]
public class JenisTpsController : Controller
{
    private readonly IJenisTps repo;

    public JenisTpsController(IJenisTps repo)
    {
        this.repo = repo;
    }

    [HttpGet("/transport/jenis-tps")]
    public IActionResult Index() => View("~/Views/Transport/JenisTps/Index.cshtml");

    [HttpGet("/transport/jenis-tps/create")]
    public IActionResult Create() => PartialView("~/Views/Transport/JenisTps/AddEdit.cshtml", new JenisTps());

    [HttpGet("/transport/jenis-tps/edit")]
    public async Task<IActionResult> Edit(int jenisID) => PartialView("~/Views/Transport/JenisTps/AddEdit.cshtml",
        await repo.JenisTps.FirstOrDefaultAsync(j => j.JenisID == jenisID));

    [HttpPost("/transport/jenis-tps/save")]
    public async Task<IActionResult> SaveDataAsync(JenisTps jenis)
    {
        if (ModelState.IsValid)
        {
            await repo.SaveDataAsync(jenis);
            return Json(Result.Success());
        }

        return PartialView("~/Views/Transport/JenisTps/AddEdit.cshtml", jenis);
    }
}
