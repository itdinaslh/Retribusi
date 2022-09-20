using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retribusi.Repositories;
using System.Linq.Dynamic.Core;

namespace Retribusi.Controllers.api;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class JenisTpsApiController : ControllerBase
{
    private readonly IJenisTps repo;

    public JenisTpsApiController(IJenisTps repo)
    {
        this.repo = repo;
    }

    [HttpPost("/api/transport/jenis-tps")]
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

        var init = repo.JenisTps.Select(x => new {
            jenisID = x.JenisID,
            namaJenis = x.NamaJenis
        });

        if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
        {
            init = init.OrderBy(sortColumn + " " + sortColumnDirection);
        }

        if (!string.IsNullOrEmpty(searchValue))
        {
            init = init.Where(a => a.namaJenis.ToLower().Contains(searchValue.ToLower()));
        }

        recordsTotal = init.Count();

        var result = await init.Skip(skip).Take(pageSize).ToListAsync();

        var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = result };

        return Ok(jsonData);
    }

    [HttpGet("/api/transport/jenis-tps/search")]
    public async Task<IActionResult> SearchMerk(string? term)
    {
        var data = await repo.JenisTps
            .Where(k => !String.IsNullOrEmpty(term) ?
                k.NamaJenis.ToLower().Contains(term.ToLower()) : true
            ).Select(s => new {
                id = s.JenisID,
                namaJenis = s.NamaJenis
            }).Take(10).ToListAsync();

        return Ok(data);
    }
}
