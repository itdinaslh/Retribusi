using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retribusi.Entities;
using Retribusi.Helpers;
using Retribusi.Repositories;

namespace Retribusi.Controllers;

[Authorize]
public class MerkController : Controller
{
    private readonly IMerkKendaraan repo;

    public MerkController(IMerkKendaraan repo)
    {
        this.repo = repo;
    }

    [HttpGet("/transport/merk")]
    public IActionResult Index() => View("~/Views/Transport/Merk/Index.cshtml");

    [HttpGet("/transport/merk/create")]
    public IActionResult Create() => PartialView("~/Views/Transport/Merk/AddEdit.cshtml", new MerkKendaraan());

    [HttpGet("/transport/merk/edit")]
    public async Task<IActionResult> Edit(int merkId) => PartialView("~/Views/Transport/Merk/AddEdit.cshtml",
        await repo.MerkKendaraans.FirstOrDefaultAsync(m => m.MerkKendaraanId == merkId)
    );

    [HttpPost("/transport/merk/save")]
    public async Task<IActionResult> SaveDataAsync(MerkKendaraan merk)
    {
        if (ModelState.IsValid)
        {
            await repo.SaveDataAsync(merk);
            return Json(Result.Success());
        }

        return PartialView("~/Views/Transport/Merk/AddEdit.cshtml", merk);
    }
}
