using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface ITps
{
    IQueryable<Tps> Tps { get; }

    Task SaveDataAsync(Tps tps);
}
