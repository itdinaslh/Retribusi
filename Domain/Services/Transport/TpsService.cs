using Retribusi.Data;
using Retribusi.Entities;
using Retribusi.Repositories;

namespace Retribusi.Services;

public class TpsService : ITps
{
    private readonly AppDbContext context;

    public TpsService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<Tps> Tps => context.Tps;

    public async Task SaveDataAsync(Tps tps)
    {
        if (tps.TpsId == 0)
        {
            await context.AddAsync(tps);
        } else
        {
            Tps? data = await context.Tps.FindAsync(tps.TpsId);

            if (data is not null)
            {
                 
            }
        }        
    }
}
