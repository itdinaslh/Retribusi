using Microsoft.EntityFrameworkCore;
using Retribusi.Entities;

namespace Retribusi.Data;

public class AppDbContext : DbContext
{
#nullable disable

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


    // Handle Main Master Data
    public DbSet<Bidang> Bidangs { get; set; }
    public DbSet<Provinsi> Provinsis { get; set; }
    public DbSet<Kabupaten> Kabupatens { get; set; }
    public DbSet<Kecamatan> Kecamatans { get; set; }
    public DbSet<Kelurahan> Kelurahans { get; set; }
    public DbSet<StatusWR> Statuses { get; set; }
    public DbSet<StatusLahan> StatusLahans { get; set; }
    public DbSet<Penugasan> Penugasans { get; set; }
    public DbSet<JenisWR> JenisWRs { get; set; }

    // Handle Kendaraan
    public DbSet<JenisKendaraan> JenisKendaraans { get; set; }
    public DbSet<MerkKendaraan> MerkKendaraans { get; set; }
    public DbSet<TipeKendaraan> TipeKendaraans { get; set; }
    public DbSet<JenisTps> JenisTps { get; set; }
    public DbSet<Tps> Tps { get; set; }
    public DbSet<Kendaraan> Kendaraans { get; set; }

    // Handle Pegawai
    public DbSet<TipePegawai> TipePegawais { get; set; }
    public DbSet<Pegawai> Pegawais { get; set; }
    public DbSet<Driver> Drivers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Kendaraan>()
            .HasOne(k => k.BidangAsal)
            .WithMany(b => b.KendaraanAsal)
            .HasForeignKey(k => k.BidangAsalId).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Kendaraan>()
            .HasOne(k => k.KabupatenAsal)
            .WithMany(kab => kab.KendaraanAsal)
            .HasForeignKey(k => k.KabupatenAsalId).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Kendaraan>()
            .HasOne(k => k.KecamatanAsal)
            .WithMany(kec => kec.KendaraanAsal)
            .HasForeignKey(k => k.KecamatanAsalId).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Kendaraan>()
            .HasOne(k => k.BidangPenugasan)
            .WithMany(b => b.KendaraanPenugasan)
            .HasForeignKey(k => k.BidangPenugasanId).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Kendaraan>()
            .HasOne(k => k.KabupatenPenugasan)
            .WithMany(kab => kab.KendaraanPenugasan)
            .HasForeignKey(k => k.KabupatenPenugasanId).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Kendaraan>()
            .HasOne(k => k.KecamatanPenugasan)
            .WithMany(kec => kec.KendaraanPenugasan)
            .HasForeignKey(k => k.KecamatanPenugasanId).OnDelete(DeleteBehavior.Restrict);
    }
}
