﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Retribusi.Repositories;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Retribusi.Controllers.api;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class DriverApiController : ControllerBase
{
    private readonly IPegawai repo;

    public DriverApiController(IPegawai repo)
    {
        this.repo = repo;
    }

    [HttpPost("/api/transport/driver")]
    public async Task<IActionResult> DriverTable()
    {
        var draw = Request.Form["draw"].FirstOrDefault();
        var start = Request.Form["start"].FirstOrDefault();
        var length = Request.Form["length"].FirstOrDefault();
        var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
        var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
        var searchValue = Request.Form["search[value]"].FirstOrDefault();
        int pageSize = length != null ? Convert.ToInt32(length) : 0;
        int skip = start != null ? Convert.ToInt32(start) : 0;
        int recordsTotal = 0;

        var init = repo.Pegawais.Where(x => x.RoleId == 2)
            .Select(x => new {
                pegawaiId = x.PegawaiId,
                nama = x.NamaPegawai,
                nik = x.NIK,
                noHp = x.NoHP,
                tipe = x.TipePegawai.NamaTipe,
                status = x.StatusAktif == true ? "Aktif" : "Non Aktif",
                bidang = x.Bidang!.NamaBidang,
                kota = x.Kecamatan!.Kabupaten.NamaKabupaten,
                kecamatan = x.Kecamatan.NamaKecamatan
        });

        if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
        {
            init = init.OrderBy(sortColumn + " " + sortColumnDirection);
        }

        if (!string.IsNullOrEmpty(searchValue))
        {
            init = init.Where(a => a.nama.ToLower().Contains(searchValue.ToLower()));
        }

        recordsTotal = init.Count();

        var result = await init.Skip(skip).Take(pageSize).ToListAsync();

        var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = result };

        return Ok(jsonData);
    }
}
