using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Retribusi.Entities;
using Retribusi.Helpers;
using Retribusi.Repositories;

namespace Retribusi.Controllers;

[Authorize]
public class PenugasanController : Controller
{
    private readonly IPenugasan repo;

    public PenugasanController(IPenugasan repo)
    {
        this.repo = repo;
    }

    [HttpGet("/master/penugasan")]
    public IActionResult Index()
    {
        return View("~/Views/Master/Penugasan/Index.cshtml");
    }

    [HttpGet("/master/penugasan/create")]
    public IActionResult Create()
    {
        return PartialView("~/Views/Master/Penugasan/AddEdit.cshtml", new Penugasan());
    }

    [HttpGet("/master/penugasan/edit")]
    public async Task<IActionResult> Edit(int id)
    {
        Penugasan? data = await repo.Penugasans.FirstOrDefaultAsync(p => p.PenugasanId == id);

        if (data is not null)
            return PartialView("~/Views/Master/Penugasan/AddEdit.cshtml", data);

        return NotFound();

    }

    [HttpPost("/master/penugasan/store")]
    public async Task<IActionResult> SaveDataAsync(Penugasan tugas)
    {
        if (ModelState.IsValid)
        {
            await repo.SaveDataAsync(tugas);

            return Json(Result.Success());
        }

        return PartialView("~/Views/Master/Penugasan/AddEdit.cshtml", tugas);
    }
}
