using Retribusi.Entities;
using Retribusi.Data;
using Retribusi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Retribusi.Services;

public class KecamatanService : IKecamatanRepo {
    private AppDbContext context;

    public KecamatanService(AppDbContext ctx) => context = ctx;

    public IQueryable<Kecamatan> Kecamatans => context.Kecamatans;
}