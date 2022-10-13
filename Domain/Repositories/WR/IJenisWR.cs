using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IJenisWR
{
    IQueryable<JenisWR> JenisWRs { get; }

    Task SaveDataAsync(JenisWR jenis);
}
