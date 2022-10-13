using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IJenisTps
{
    IQueryable<JenisTps> JenisTps { get; }

    Task SaveDataAsync(JenisTps jenis);
}
