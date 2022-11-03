using Retribusi.Data;
using Retribusi.Entities;
using Retribusi.Repositories;

namespace Retribusi.Services;

public class DriverService : IDriver
{
    private readonly AppDbContext context;

    public DriverService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<Driver> Drivers => context.Drivers;

    public async Task SaveDataAsync(Driver driver)
    {
        if (driver.DriverId == Guid.Empty)
        {
            await context.AddAsync(driver);
        } else
        {
            Driver? data = await context.Drivers.FindAsync(driver.DriverId);

            if (data is not null)
            {
                data.NIK = driver.NIK;
                data.Nama = driver.Nama;
                data.NoHP = driver.NoHP;
                data.Email = driver.Email;
                data.IsActive = true;
                data.TahunMasuk = driver.TahunMasuk;
                data.Catatan = driver.Catatan;
                data.BidangId = driver.BidangId;
                data.TipePegawaiId = driver.TipePegawaiId;
                data.KecamatanID = driver.KecamatanID;
                data.KelurahanID = driver.KelurahanID;
                data.UpdatedAt = driver.UpdatedAt;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }
}
