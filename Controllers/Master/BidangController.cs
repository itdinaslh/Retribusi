﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Retribusi.Entities;
using Retribusi.Helpers;
using Retribusi.Repositories;

namespace Retribusi.Controllers;

[Authorize]
public class BidangController : Controller
{
    private readonly IBidangRepo repo;

    public BidangController(IBidangRepo repo)
    {
        this.repo = repo;
    }

    [HttpGet("/master/bidang")]
    public IActionResult Index()
    {
        return View("~/Views/Master/Bidang/Index.cshtml");
    }

    [HttpGet("/master/bidang/create")]
    public IActionResult Create() => PartialView("~/Views/Master/Bidang/AddEdit.cshtml", new Bidang { BidangID = Guid.Empty });

    [HttpGet("/master/bidang/edit")]
    public async Task<IActionResult> Edit(Guid bidangId) => PartialView("/Views/Master/Bidang/AddEdit.cshtml",
        await repo.Bidangs.FirstOrDefaultAsync(b => b.BidangID == bidangId));

    [HttpPost("/master/bidang/save")]
    public async Task<IActionResult> SaveBidangAsync(Bidang bidang)
    {
        if (ModelState.IsValid)
        {
            await repo.SaveBidangAsync(bidang);
            return Json(Result.Success());
        }
        else
        {
            return PartialView("~/Views/Master/Bidang/AddEdit.cshtml", bidang);
        }
    }
}
