using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Retribusi.Helpers;
using Retribusi.Models;
using Retribusi.Repositories;
using Retribusi.Entities;
using Microsoft.EntityFrameworkCore;

namespace Retribusi.Controllers;

[Authorize(Roles = "SysAdmin, WRAdmin")]
public class DriverController : Controller
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly IDriver repo;

    public DriverController(IHttpClientFactory clientFactory, IDriver driver)
    {
        _clientFactory = clientFactory;
        repo = driver;
    }

    [HttpGet("/transport/drivers")]
    public IActionResult Index()
    {
        return View("~/Views/Transport/Driver/Index.cshtml");
    }

    [HttpGet("/transport/driver/create")]
    public IActionResult Create()
    {
        return PartialView("~/Views/Transport/Driver/AddEdit.cshtml", new DriverVM
        {
            Driver = new Driver
            {
                DriverId = Guid.Empty
            }
        });
    }

    [HttpGet("/transport/driver/edit")]
    public async Task<IActionResult> Edit(Guid driverId)
    {
        var data = await repo.Drivers.Select(x => new
        {
            x.DriverId,
            x.NIK,
            x.Nama,
            x.TglLahir,
            x.NoHP,
            x.Email,
            x.Alamat,
            x.IsActive,
            x.TahunMasuk,
            x.Catatan,
            x.BidangId,
            x.TipePegawaiId,
            x.KecamatanID,
            x.KelurahanID,
            NamaBidang = x.Bidang.NamaBidang,
            KotaId = x.Kecamatan.KabupatenID,
            NamaKota = x.Kecamatan.Kabupaten.NamaKabupaten,
            NamaKecamatan = x.Kecamatan.NamaKecamatan,
            NamaKelurahan = x.Kelurahan!.NamaKelurahan
        }).FirstOrDefaultAsync(d => d.DriverId == driverId);

        if (data is not null)
        {
            return PartialView("~/Views/Transport/Driver/AddEdit.cshtml", new DriverVM
            {
                Driver = new Driver
                {
                    DriverId = data.DriverId,
                    NIK = data.NIK,
                    Nama = data.Nama,
                    TglLahir = data.TglLahir,
                    NoHP = data.NoHP,
                    Email = data.Email,
                    Alamat = data.Alamat,
                    IsActive = data.IsActive,
                    TahunMasuk = data.TahunMasuk,
                    Catatan = data.Catatan,
                    BidangId = data.BidangId,
                    TipePegawaiId = data.TipePegawaiId,
                    KecamatanID = data.KecamatanID,
                    KelurahanID = data.KelurahanID
                },
                KotaId = data.KotaId,
                NamaBidang = data.NamaBidang,
                NamaKota = data.NamaKota,
                NamaKecamatan = data.NamaKecamatan,
                NamaKelurahan = data.NamaKelurahan
            });
        }

        return NotFound();
    }

    [HttpPost("/transport/driver/store")]
    public async Task<IActionResult> StoreDriver(DriverVM model)
    {
#nullable disable

        if (ModelState.IsValid)
        {
            UserModel user = new()
            {
                FullName = model.Driver.Nama,
                Email = model.Driver.Email,
                Password = "Driver123$",
                Roles = "Driver",
                UserName = model.Driver.NIK
            };

            try
            {
                var client = _clientFactory.CreateClient("UserClient");

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("FullName", user.FullName),
                    new KeyValuePair<string, string>("Email", user.Email),
                    new KeyValuePair<string, string>("Password", user.Password),
                    new KeyValuePair<string, string>("Roles", user.Roles),
                    new KeyValuePair<string, string>("UserName", user.UserName)
                });

                HttpResponseMessage response = await client.PostAsync("/api/user/store", content);

                if (!response.IsSuccessStatusCode)
                {
                    return StatusCode(500, "Request failed, something went wrong!");
                } else
                {
                    await repo.SaveDataAsync(model.Driver);
                }

            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }            

            return Json(Result.Success());

        }

        return PartialView("~/Views/Transport/Driver/AddEdit.cshtml", model);
    }
}
