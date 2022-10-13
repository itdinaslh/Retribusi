using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IKendaraan
{
    IQueryable<Kendaraan> Kendaraans { get; }

    Task SaveDataAsync(Kendaraan kendaraan);
}
