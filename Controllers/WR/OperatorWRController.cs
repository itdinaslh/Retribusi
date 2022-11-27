using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retribusi.Entities;
using Retribusi.Helpers;
using Retribusi.Models;
using Retribusi.Repositories;
using System.Globalization;

namespace Retribusi.Controllers;

public class OperatorWRController : Controller
{

    private readonly IPegawai repo;

    public OperatorWRController(IPegawai repo)
    {
        this.repo = repo;
    }

    [HttpGet("/wr/operator")]
    public IActionResult Index()
    {
        return View("~/Views/WR/Operator/Index.cshtml");
    }

    [HttpGet("/wr/operator/create")]
    public IActionResult Create()
    {
        return PartialView("~/Views/WR/Operator/AddEdit.cshtml", new PegawaiVM
        {
            Pegawai = new Pegawai
            {
                PegawaiId = Guid.Empty,
                RoleId = 3
            }
        });
    }

    [HttpGet("/wr/operator/edit")]
    public async Task<IActionResult> Edit(Guid operatorId)
    {
        var data = await repo.Pegawais.Select(x => new
        {
            x.PegawaiId,
            x.NIK,
            x.NIP,
            x.NamaPegawai,
            x.TglLahir,
            x.NoHP,
            x.Email,
            x.Alamat,
            x.StatusAktif,            
            x.Catatan,
            x.BidangId,            
            x.KecamatanID,
            x.KelurahanID,
            NamaBidang = x.Bidang!.NamaBidang,
            KotaID = x.Kecamatan!.KabupatenID,
            NamaKota = x.Kecamatan.Kabupaten.NamaKabupaten,
            NamaKecamatan = x.Kecamatan.NamaKecamatan,
            NamaKelurahan = x.Kelurahan!.NamaKelurahan
        }).FirstOrDefaultAsync(d => d.PegawaiId == operatorId);

        if (data is not null)
        {
            return PartialView("~/Views/WR/Operator/AddEdit.cshtml", new PegawaiVM
            {
                Pegawai = new Pegawai
                {
                    PegawaiId = data.PegawaiId,
                    NIK = data.NIK,
                    NIP = data.NIP,
                    NamaPegawai = data.NamaPegawai,
                    TglLahir = data.TglLahir,
                    NoHP = data.NoHP,
                    Email = data.Email,
                    Alamat = data.Alamat,
                    StatusAktif = data.StatusAktif,                    
                    Catatan = data.Catatan,
                    BidangId = data.BidangId,                    
                    KecamatanID = data.KecamatanID,
                    KelurahanID = data.KelurahanID
                },
                Lahir = data.TglLahir.ToString("dd-MM-yyyy"),
                KotaID = data.KotaID,
                NamaBidang = data.NamaBidang,
                NamaKota = data.NamaKota,
                NamaKecamatan = data.NamaKecamatan,
                NamaKelurahan = data.NamaKelurahan
            });
        }

        return NotFound();
    }

    [HttpPost("/wr/operator/store")]
    public async Task<IActionResult> Store(PegawaiVM model)
    {
#nullable disable

        model.Pegawai.RoleId = 3;
        model.Pegawai.TipePegawaiId = 1;

        model.Pegawai.TglLahir = DateOnly.ParseExact(model.Lahir, "dd-MM-yyyy", new CultureInfo("id-ID"));

        if (ModelState.IsValid)
        {
            await repo.SaveDataAsync(model.Pegawai);

            return Json(Result.Success());

        }

        return PartialView("~/Views/Transport/Driver/AddEdit.cshtml", model);
    }
}
