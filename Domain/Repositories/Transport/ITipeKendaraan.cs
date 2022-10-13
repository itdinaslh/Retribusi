using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface ITipeKendaraan
{
    IQueryable<TipeKendaraan> TipeKendaraans { get; }

    Task SaveDataAsync(TipeKendaraan tipe);
}
