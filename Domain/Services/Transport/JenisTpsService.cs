using Microsoft.EntityFrameworkCore;
using Retribusi.Data;
using Retribusi.Entities;
using Retribusi.Repositories;

namespace Retribusi.Services;

public class JenisTpsService : IJenisTps
{
    private readonly AppDbContext context;

    public JenisTpsService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<JenisTps> JenisTps => context.JenisTps;

    public async Task SaveDataAsync(JenisTps jenis)
    {
        if (jenis.JenisID == 0)
        {
            await context.AddAsync(jenis);
        }
        else
        {
            JenisTps? jns = await context.JenisTps.FirstOrDefaultAsync(j => j.JenisID == jenis.JenisID);
            if (jns is not null)
            {
                jns.NamaJenis = jenis.NamaJenis.Trim();

                context.Update(jns);
            }            
        }

        await context.SaveChangesAsync();
    }
}
