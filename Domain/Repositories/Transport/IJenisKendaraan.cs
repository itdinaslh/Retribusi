using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IJenisKendaraan
{
    IQueryable<JenisKendaraan> JenisKendaraans { get; }

    Task SaveDataAsync(JenisKendaraan jenisKendaraan);
}
