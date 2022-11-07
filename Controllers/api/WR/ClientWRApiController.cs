using Microsoft.AspNetCore.Mvc;
using Retribusi.Repositories;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;

namespace Retribusi.Controllers.api;

[Route("api/[controller]")]
[ApiController]
public class ClientWRApiController : ControllerBase
{
    private readonly IClientWR repo;

    public ClientWRApiController(IClientWR repo)
    {
        this.repo = repo;
    }

    [HttpPost("/api/wr/clients")]
    public async Task<IActionResult> ClientWRTable()
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

        var init = repo.ClientWRs
            .Select(x => new {
                clientId = x.ClientId,
                objectName = x.ObjectName,
                objectPhone = x.ObjectPhone,
                alamat = x.Alamat,
                namaJenis = x.JenisWR.NamaJenis,
                kota = x.Kecamatan.Kabupaten.NamaKabupaten,
                //status = x.StatusAktif == true ? "Aktif" : "Non Aktif",
                kecamatan = x.Kecamatan.NamaKecamatan,
                kelurahan = x.Kelurahan!.NamaKelurahan                
            });

        if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
        {
            init = init.OrderBy(sortColumn + " " + sortColumnDirection);
        }

        if (!string.IsNullOrEmpty(searchValue))
        {
            init = init.Where(a => a.objectName.ToLower().Contains(searchValue.ToLower()));
        }

        recordsTotal = init.Count();

        var result = await init.Skip(skip).Take(pageSize).ToListAsync();

        var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = result };

        return Ok(jsonData);
    }
}
