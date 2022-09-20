using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Retribusi.Repositories;
using Retribusi.Models;
using Microsoft.EntityFrameworkCore;
using Retribusi.Entities;
using Retribusi.Helpers;

namespace Retribusi.Controllers;

[Authorize]
public class TipeKendaraanController : Controller
{
    private readonly ITipeKendaraan repo;

    public TipeKendaraanController(ITipeKendaraan repo)
    {
        this.repo = repo;
    }

    [HttpGet("/transport/tipe-kendaraan")]
    public IActionResult Index() => View("~/Views/Transport/TipeKendaraan/Index.cshtml");

    [HttpGet("/transport/tipe-kendaraan/create")]
    public IActionResult Create() => PartialView("~/Views/Transport/TipeKendaraan/AddEdit.cshtml", new TipeKendaraanVM());

    [HttpGet("/transport/tipe-kendaraan/edit")]
    public async Task<IActionResult> Edit(int id)
    {
        TipeKendaraan? tipe = await repo.TipeKendaraans.FirstOrDefaultAsync(t => t.TipeKendaraanId == id);

        if (tipe is not null)
            return PartialView("~/Views/Transport/TipeKendaraan/AddEdit.cshtml", new TipeKendaraanVM { TipeKendaraan = tipe });

        return NotFound();
    }

    [HttpPost("/transport/tipe-kendaraan/save")]
    public async Task<IActionResult> SaveDataAsync(TipeKendaraanVM vm)
    {
        if (ModelState.IsValid)
        {
            await repo.SaveDataAsync(vm.TipeKendaraan);

            return Json(Result.Success());
        }

        return PartialView("~/Views/Transport/TipeKendaraan/AddEdit.cshtml", vm);
    }

}
