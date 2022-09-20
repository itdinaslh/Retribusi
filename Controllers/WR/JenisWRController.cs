using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retribusi.Entities;
using Retribusi.Helpers;
using Retribusi.Repositories;

namespace Retribusi.Controllers;

[Authorize]
public class JenisWRController : Controller
{
    private readonly IJenisWR repo;

    public JenisWRController(IJenisWR repo)
    {
        this.repo = repo;
    }

    [HttpGet("/wr/jenis")]
    public IActionResult Index() => View("~/Views/WR/Jenis/Index.cshtml");

    [HttpGet("/wr/jenis/create")]
    public IActionResult Create() => PartialView("~/Views/WR/Jenis/AddEdit.cshtml", new JenisWR());

    [HttpGet("/wr/jenis/edit")]
    public async Task<IActionResult> Edit(int jenisId)
    {
        JenisWR? jns = await repo.JenisWRs.FirstOrDefaultAsync(j => j.JenisID == jenisId);

        if (jns is not null)
            return PartialView("~/Views/WR/Jenis/AddEdit.cshtml", jns);

        return NotFound();
    }

    [HttpPost("/wr/jenis/save")]
    public async Task<IActionResult> SaveDataAsync(JenisWR jenisWr)
    {
        if (ModelState.IsValid)
        {
            await repo.SaveDataAsync(jenisWr);
            return Json(Result.Success());
        }

        return PartialView("~/Views/WR/Jenis/AddEdit.cshtml", jenisWr);
    }
}
