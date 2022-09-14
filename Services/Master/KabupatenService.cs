using Retribusi.Entities;
using Retribusi.Data;
using Retribusi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Retribusi.Services;

public class KabupatenService : IKabupatenRepo {
    private AppDbContext context;

    public KabupatenService(AppDbContext ctx) => context = ctx;

    public IQueryable<Kabupaten> Kabupatens => context.Kabupatens;
}