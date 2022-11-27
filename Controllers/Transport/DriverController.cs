using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retribusi.Entities;
using Retribusi.Helpers;
using Retribusi.Models;
using Retribusi.Repositories;
using System.Text.Json.Nodes;
using System.Globalization;

namespace Retribusi.Controllers;

[Authorize(Roles = "SysAdmin, WRAdmin")]
public class DriverController : Controller
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly IPegawai repo;

    public DriverController(IHttpClientFactory clientFactory, IPegawai pegawai)
    {
        _clientFactory = clientFactory;
        repo = pegawai;
    }

    [HttpGet("/transport/drivers")]
    public IActionResult Index()
    {
        return View("~/Views/Transport/Driver/Index.cshtml");
    }

    [HttpGet("/transport/driver/create")]
    public IActionResult Create()
    {
        return PartialView("~/Views/Transport/Driver/AddEdit.cshtml", new PegawaiVM());
    }

    [HttpGet("/transport/driver/edit")]
    public async Task<IActionResult> Edit(Guid driverId)
    {
        var data = await repo.Pegawais.Select(x => new
        {
            x.PegawaiId,
            x.NIK,
            x.NamaPegawai,
            x.TglLahir,
            x.NoHP,
            x.Email,
            x.Alamat,
            x.StatusAktif,
            x.TahunMasuk,
            x.Catatan,
            x.BidangId,
            x.TipePegawaiId,
            x.KecamatanID,
            x.KelurahanID,
            NamaBidang = x.Bidang!.NamaBidang,
            KotaID = x.Kecamatan!.KabupatenID,
            NamaKota = x.Kecamatan.Kabupaten.NamaKabupaten,
            NamaKecamatan = x.Kecamatan.NamaKecamatan,
            NamaKelurahan = x.Kelurahan!.NamaKelurahan
        }).FirstOrDefaultAsync(d => d.PegawaiId == driverId);

        if (data is not null)
        {
            return PartialView("~/Views/Transport/Driver/AddEdit.cshtml", new PegawaiVM
            {
                Pegawai = new Pegawai
                {
                    PegawaiId = data.PegawaiId,
                    NIK = data.NIK,
                    NamaPegawai = data.NamaPegawai,
                    TglLahir = data.TglLahir,
                    NoHP = data.NoHP,
                    Email = data.Email,
                    Alamat = data.Alamat,
                    StatusAktif= data.StatusAktif,
                    TahunMasuk = data.TahunMasuk,
                    Catatan = data.Catatan,
                    BidangId = data.BidangId,
                    TipePegawaiId = data.TipePegawaiId,
                    KecamatanID = data.KecamatanID,
                    KelurahanID = data.KelurahanID
                },
                TheNIK = data.NIK,
                NamaOrang = data.NamaPegawai,
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

    [HttpGet("/transport/driver/check")]  
    public async Task<IActionResult> CheckDriver(string nik)
    {
#nullable disable
        try
        {
            var client = _clientFactory.CreateClient("UserClient");

            HttpResponseMessage response = await client.GetAsync("/api/pegawai/search?nik=" + nik);

            var str = response.Content.ReadAsStringAsync().Result;

            var data = JsonObject.Parse(str);            

            return Json(data);

        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPost("/transport/driver/store")]
    public async Task<IActionResult> StoreDriver(PegawaiVM model) {
        model.Pegawai.RoleId = 2;
        model.Pegawai.TglLahir = DateOnly.ParseExact(model.Lahir, "dd-MM-yyyy", new CultureInfo("id-ID"));

        if (ModelState.IsValid) {
            Pegawai peg = await repo.Pegawais.Where(x => x.NIK == model.Pegawai.NIK).FirstOrDefaultAsync();

            if (peg is not null) {
                return PartialView("~/Views/Transport/Driver/AddEdit.cshtml", model);
            }

            await repo.SaveDataAsync(model.Pegawai);

            return Json(Result.Success());
        }

        return PartialView("~/Views/Transport/Driver/AddEdit.cshtml", model);
    }
}
