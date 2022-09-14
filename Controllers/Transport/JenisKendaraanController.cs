using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

using Retribusi.Entities;
using Retribusi.Repositories;
using Retribusi.Helpers;

namespace Retribusi.Controllers;

[Authorize]
public class JenisKendaraanController : Controller
{
    private readonly IJenisKendaraan repo;

    public JenisKendaraanController(IJenisKendaraan repo)
    {
        this.repo = repo;
    }

    [HttpGet("/transport/jenis-kendaraan")]
    public IActionResult Index() => View("~/Views/Transport/JenisKendaraan/Index.cshtml");

    [HttpGet("/transport/jenis-kendaraan/create")]
    public IActionResult Create() => PartialView("~/Views/Transport/JenisKendaraan/AddEdit.cshtml", new JenisKendaraan());

    [HttpGet("/transport/jenis-kendaraan/edit")]
    public async Task<IActionResult> Edit(int jenisID)
    {
        JenisKendaraan? jns = await repo.JenisKendaraans.FirstOrDefaultAsync(j => j.JenisID == jenisID);

        if (jns is not null)
            return PartialView("~/Views/Transport/JenisKendaraan/AddEdit.cshtml", jns);

        return NotFound();
    }

    [HttpPost("/transport/jenis-kendaraan/save")]
    public async Task<IActionResult> SaveDataAsync(JenisKendaraan jnsKendaraan)
    {
        if (ModelState.IsValid)
        {
            await repo.SaveDataAsync(jnsKendaraan);
            return Json(Result.Success());
        }

        return PartialView("~/Views/Transport/JenisKendaraan/AddEdit.cshtml", jnsKendaraan);
    }
}
