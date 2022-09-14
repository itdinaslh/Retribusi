using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IProvinsiRepo {
    public IQueryable<Provinsi> Provinsis { get; }
}