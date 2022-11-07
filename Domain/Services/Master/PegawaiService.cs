using Retribusi.Entities;
using Retribusi.Data;
using Retribusi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Retribusi.Services;

public class PegawaiService : IPegawai
{
    private readonly AppDbContext context;

    public PegawaiService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<Pegawai> Pegawais => context.Pegawais;

    public async Task SaveDataAsync(Pegawai peg)
    {
        if (peg.PegawaiId == Guid.Empty)
        {
            peg.PegawaiId = Guid.NewGuid();
            await context.AddAsync(peg);
        } else
        {
            Pegawai? data = await context.Pegawais.FindAsync(peg.PegawaiId);

            if (data is not null)
            {
                data.NamaPegawai = peg.NamaPegawai;
                data.NIK = peg.NIK;
                data.NIP = peg.NIP;
                data.TglLahir = peg.TglLahir;
                data.NoHP = peg.NoHP;
                data.Email = peg.Email;
                data.TipePegawaiId = peg.TipePegawaiId;
                data.StatusAktif = peg.StatusAktif;
                data.TahunMasuk = peg.TahunMasuk;
                data.Catatan = peg.Catatan;
                data.RoleId = peg.RoleId;
                data.BidangId = peg.BidangId;                
                data.KecamatanID = peg.KecamatanID;
                data.KelurahanID = peg.KelurahanID;
                data.UpdatedAt = DateTime.Now;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }
}
