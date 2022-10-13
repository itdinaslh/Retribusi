using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IMerkKendaraan
{
    IQueryable<MerkKendaraan> MerkKendaraans { get; }

    Task SaveDataAsync(MerkKendaraan merkKendaraan);
}
