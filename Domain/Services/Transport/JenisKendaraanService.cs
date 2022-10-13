using Microsoft.EntityFrameworkCore;
using Retribusi.Data;
using Retribusi.Entities;
using Retribusi.Repositories;

namespace Retribusi.Services;

public class JenisKendaraanService : IJenisKendaraan
{
    private readonly AppDbContext context;

    public JenisKendaraanService(AppDbContext ctx) => context = ctx;

    public IQueryable<JenisKendaraan> JenisKendaraans => context.JenisKendaraans;

    public async Task SaveDataAsync(JenisKendaraan jenis)
    {
        if (jenis.JenisID == 0)
        {
            await context.AddAsync(jenis);
        }
        else
        {
            JenisKendaraan? jns = await context.JenisKendaraans.FirstOrDefaultAsync(j => j.JenisID == jenis.JenisID);
            if (jns is not null)
            {
                jns.KodeJenis = jenis.KodeJenis;
                jns.NamaJenis = jenis.NamaJenis;
                jns.UpdatedAt = DateTime.Now;

                context.Update(jns);
            }
        }

        await context.SaveChangesAsync();
    }
}
