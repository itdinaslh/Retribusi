using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retribusi.Entities;
using Retribusi.Helpers;
using Retribusi.Models;
using Retribusi.Repositories;

namespace Retribusi.Controllers;

[Authorize(Roles = "SysAdmin, SilikaAdmin")]
public class KendaraanController : Controller
{
    private readonly IKendaraan repo;

    public KendaraanController(IKendaraan repo)
    {
        this.repo = repo;
    }

    [HttpGet("/transport/kendaraan")]
    public IActionResult Index()
    {
        return View("~/Views/Transport/Kendaraan/Index.cshtml");
    }

    [HttpGet("/transport/kendaraan/create")]
    public IActionResult Create()
    {
        return PartialView("~/Views/Transport/Kendaraan/AddEdit.cshtml", new KendaraanVM());
    }

    [HttpGet("/transport/kendaraan/edit")]
    public async Task<IActionResult> Edit(int id)
    {
        var data = await repo.Kendaraans
            .Select(x => new
            {
                x.KendaraanId,
                x.NoPolisi,
                x.NoPintu,
                x.MerkKendaraanId,
                x.TipeKendaraanId,
                x.JenisKendaraanId,                
                x.BidangAsalId,
                x.KabupatenAsalId,
                x.KecamatanAsalId,
                x.TahunPengadaan,
                x.KonsumsiBBM,
                x.NoRangka,
                x.FungsiKendaraanID,
                x.BidangPenugasanId,
                x.KabupatenPenugasanId,
                x.KecamatanPenugasanId,
                x.MerkKendaraan!.NamaMerk,
                x.TipeKendaraan!.NamaTipe,
                x.JenisKendaraan!.NamaJenis,
                x.FungsiKendaraan!.NamaFungsi,
                BidangAsal = x.BidangAsal!.NamaBidang,
                KabupatenAsal = x.KabupatenAsal!.NamaKabupaten,
                KecamatanAsal = x.KecamatanAsal!.NamaKecamatan,
                BidangTugas = x.BidangPenugasan!.NamaBidang,
                KabupatenTugas = x.KabupatenPenugasan!.NamaKabupaten,
                KecamatanTugas = x.KecamatanPenugasan!.NamaKecamatan
            })
            .FirstOrDefaultAsync(k => k.KendaraanId == id);

        return PartialView("~/Views/Transport/Kendaraan/AddEdit.cshtml", new KendaraanVM
        {
            Kendaraan = new Kendaraan
            {
                KendaraanId = data!.KendaraanId,
                NoPolisi = data!.NoPolisi,
                NoPintu = data!.NoPintu,
                MerkKendaraanId = data!.MerkKendaraanId,
                TipeKendaraanId = data!.TipeKendaraanId,
                JenisKendaraanId = data!.JenisKendaraanId,
                FungsiKendaraanID = data!.FungsiKendaraanID,
                TahunPengadaan = data!.TahunPengadaan,
                NoRangka = data!.NoRangka,
                KonsumsiBBM = data!.KonsumsiBBM,
                BidangAsalId = data!.BidangAsalId,
                KabupatenAsalId = data!.KabupatenAsalId,
                KecamatanAsalId = data!.KecamatanAsalId,
                BidangPenugasanId = data!.BidangPenugasanId,
                KabupatenPenugasanId = data!.KabupatenPenugasanId,
                KecamatanPenugasanId = data!.KecamatanPenugasanId
            },
            IsSame = data!.BidangAsalId == data!.BidangPenugasanId ? true : false,
            NamaMerk = data!.NamaMerk,
            NamaTipe = data!.NamaTipe,
            NamaJenis = data!.NamaJenis,
            NamaFungsi = data!.NamaFungsi,
            BidangAsal = data!.BidangAsal,
            KabupatenAsal = data!.KabupatenAsal,
            KecamatanAsal = data!.KecamatanAsal,
            BidangTugas = data!.BidangTugas,
            KabupatenTugas = data!.KabupatenTugas,
            KecamatanTugas = data!.KecamatanTugas
        });
    }

    [HttpPost("/transport/kendaraan/store")]
    public async Task<IActionResult> SaveDataAsync(KendaraanVM model)
    {
        if (ModelState.IsValid)
        {
            if (model.IsSame)
            {
                model.Kendaraan.BidangPenugasanId = model.Kendaraan.BidangAsalId;
                model.Kendaraan.KabupatenPenugasanId = model.Kendaraan.KabupatenAsalId;
                model.Kendaraan.KecamatanPenugasanId = model.Kendaraan.KecamatanAsalId;
            }

            await repo.SaveDataAsync(model.Kendaraan);

            return Json(Result.Success());
        }

        return PartialView("~/Views/Transport/Kendaraan/AddEdit.cshtml", model);
    }
}
