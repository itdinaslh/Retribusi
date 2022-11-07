using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retribusi.Repositories;

namespace Retribusi.Controllers.api;

[Route("api/[controller]")]
[ApiController]
public class FungsiKendaraanApiController : ControllerBase
{
    private readonly IFungsiKendaraan repo;

    public FungsiKendaraanApiController(IFungsiKendaraan repo)
    {
        this.repo = repo;
    }

    [HttpGet("/api/transport/fungsi/search")]
    public async Task<IActionResult> Search(string? term)
    {
        var data = await repo.FungsiKendaraans
            .Where(k => !String.IsNullOrEmpty(term) ?
                k.NamaFungsi.ToLower().Contains(term.ToLower()) : true
            ).Select(s => new {
                id = s.FungsiKendaraanID,
                namaFungsi = s.NamaFungsi
            }).Take(10).ToListAsync();

        return Ok(data);
    }
}
