using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retribusi.Entities;
using Retribusi.Helpers;
using Retribusi.Models;
using Retribusi.Repositories;

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
        return PartialView("~/Views/Transport/Driver/AddEdit.cshtml", new PegawaiVM
        {
            Pegawai = new Pegawai
            {
                PegawaiId = Guid.Empty,
                RoleId = 2
            }
        });
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
                KotaID = data.KotaID,
                NamaBidang = data.NamaBidang,
                NamaKota = data.NamaKota,
                NamaKecamatan = data.NamaKecamatan,
                NamaKelurahan = data.NamaKelurahan
            });
        }

        return NotFound();
    }

    [HttpPost("/transport/driver/store")]
    public async Task<IActionResult> StoreDriver(PegawaiVM model)
    {
#nullable disable

        model.Pegawai.RoleId = 2;

        if (ModelState.IsValid)
        {
            if (model.Pegawai.PegawaiId == Guid.Empty)
            {
                UserModel user = new()
                {
                    FullName = model.Pegawai.NamaPegawai,
                    Email = model.Pegawai.Email,
                    Password = "Driver123$",
                    Roles = "Driver",
                    UserName = model.Pegawai.NIK,
                    PhoneNumber = model.Pegawai.NoHP
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
                    new KeyValuePair<string, string>("UserName", user.UserName),
                    new KeyValuePair<string, string>("PhoneNumber", user.PhoneNumber)
                });

                    HttpResponseMessage response = await client.PostAsync("/api/user/store", content);

                    if (!response.IsSuccessStatusCode)
                    {
                        return StatusCode(500, "Request failed, something went wrong!");
                    }
                    else
                    {

                        await repo.SaveDataAsync(model.Pegawai);
                    }

                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            } else
            {
                await repo.SaveDataAsync(model.Pegawai);
            }
                        

            return Json(Result.Success());

        }

        return PartialView("~/Views/Transport/Driver/AddEdit.cshtml", model);
    }
}
