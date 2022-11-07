using Retribusi.Data;
using Retribusi.Entities;
using Retribusi.Repositories;

namespace Retribusi.Services;

public class FungsiKendaraanService : IFungsiKendaraan
{
    private readonly AppDbContext context;

    public FungsiKendaraanService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<FungsiKendaraan> FungsiKendaraans => context.FungsiKendaraans;
}
