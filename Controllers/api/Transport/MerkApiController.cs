using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retribusi.Repositories;
using System.Linq.Dynamic.Core;

namespace Retribusi.Controllers.api;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class MerkApiController : ControllerBase
{
    private readonly IMerkKendaraan repo;

    public MerkApiController(IMerkKendaraan repo)
    {
        this.repo = repo;
    }

    [HttpPost("/api/transport/merk")]
    public async Task<IActionResult> JenisTable()
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

        var init = repo.MerkKendaraans.Select(x => new {
            merkKendaraanId = x.MerkKendaraanId,
            kodeMerk = x.KodeMerk,
            namaMerk = x.NamaMerk
        });

        if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
        {
            init = init.OrderBy(sortColumn + " " + sortColumnDirection);
        }

        if (!string.IsNullOrEmpty(searchValue))
        {
            init = init.Where(a => a.namaMerk.ToLower().Contains(searchValue.ToLower()));
        }

        recordsTotal = init.Count();

        var result = await init.Skip(skip).Take(pageSize).ToListAsync();

        var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = result };

        return Ok(jsonData);
    }

    [HttpGet("/api/transport/merk/search")]
    public async Task<IActionResult> SearchMerk(string? term)
    {
        var data = await repo.MerkKendaraans
            .Where(k => !String.IsNullOrEmpty(term) ?
                k.NamaMerk.ToLower().Contains(term.ToLower()) : true
            ).Select(s => new {
                id = s.MerkKendaraanId,
                namaMerk = s.NamaMerk
            }).Take(10).ToListAsync();

        return Ok(data);
    }
}
