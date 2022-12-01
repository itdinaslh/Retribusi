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
        if (tps.TpsId == Guid.Empty)
        {
            await context.AddAsync(tps);
        } else
        {
            Tps? data = await context.Tps.FindAsync(tps.TpsId);

            if (data is not null)
            {
                data.TpsCode = tps.TpsCode;
                data.NamaTps = tps.NamaTps;
                data.JenisTpsId = tps.JenisTpsId;
                data.KelurahanID = tps.KelurahanID;
                data.LuasLahan = tps.LuasLahan;
                data.Volume = tps.Volume;
                data.Latitude = tps.Latitude;
                data.Longitude = tps.Longitude;
                data.Alamat = tps.Alamat;
                data.StatusLahanId = tps.StatusLahanId;
                data.UpdatedAt = DateTime.Now;

                context.Update(data);
            }
        }        

        await context.SaveChangesAsync();
    }
}
