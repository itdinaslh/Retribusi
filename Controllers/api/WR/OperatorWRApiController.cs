using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retribusi.Repositories;
using System.Linq.Dynamic.Core;

namespace Retribusi.Controllers.api;

[Route("api/[controller]")]
[ApiController]
public class OperatorWRApiController : ControllerBase
{
    private readonly IPegawai repo;

    public OperatorWRApiController(IPegawai repo)
    {
        this.repo = repo;
    }

    [HttpPost("/api/wr/operator")]
    public async Task<IActionResult> OperatorTable()
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

        var init = repo.Pegawais.Where(x => x.RoleId == 3)
            .Select(x => new {
                pegawaiId = x.PegawaiId,
                nama = x.NamaPegawai,
                nip = x.NIP,
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
