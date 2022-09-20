using Retribusi.Data;
using Retribusi.Entities;
using Retribusi.Repositories;

namespace Retribusi.Services;

public class JenisWRService : IJenisWR
{
    private readonly AppDbContext context;

    public JenisWRService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<JenisWR> JenisWRs => context.JenisWRs;

    public async Task SaveDataAsync(JenisWR jenis)
    {
        if (jenis.JenisID == 0)
        {
            await context.AddAsync(jenis);
        } else
        {
            JenisWR? data = await context.JenisWRs.FindAsync(jenis.JenisID);

            if (data is not null)
            {
                data.NamaJenis = jenis.NamaJenis;
                data.NoRekening = jenis.NoRekening;
                data.UpdatedAt = DateTime.Now;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }
}
