using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IFungsiKendaraan
{
    IQueryable<FungsiKendaraan> FungsiKendaraans { get; }
}
