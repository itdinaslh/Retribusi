using Retribusi.Data;
using Retribusi.Entities;
using Retribusi.Repositories;

namespace Retribusi.Services;

public class MerkKendaraanService : IMerkKendaraan
{
    private readonly AppDbContext context;

    public MerkKendaraanService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<MerkKendaraan> MerkKendaraans => context.MerkKendaraans;

    public async Task SaveDataAsync(MerkKendaraan merkKendaraan)
    {
        if (merkKendaraan.MerkKendaraanId == 0) { 
            await context.AddAsync(merkKendaraan);
        } else
        {
            MerkKendaraan? data = await context.MerkKendaraans.FindAsync(merkKendaraan.MerkKendaraanId);

            if (data is not null)
            {
                data.NamaMerk = merkKendaraan.NamaMerk;
                data.KodeMerk = merkKendaraan.KodeMerk;
                data.UpdatedAt = DateTime.Now;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }
}
