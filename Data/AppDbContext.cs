using Microsoft.EntityFrameworkCore;
using Retribusi.Entites;

namespace Retribusi.Data;

public class AppDbContext : DbContext
{
#nullable disable

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Bidang> Bidangs { get; set; }
}
