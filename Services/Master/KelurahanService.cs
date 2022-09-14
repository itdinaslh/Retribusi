using Retribusi.Entities;
using Retribusi.Data;
using Retribusi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Retribusi.Services;

public class KelurahanService : IKelurahanRepo {
    private AppDbContext context;

    public KelurahanService(AppDbContext ctx) => context = ctx;

    public IQueryable<Kelurahan> Kelurahans => context.Kelurahans;
}