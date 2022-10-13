using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IKecamatanRepo {
    IQueryable<Kecamatan> Kecamatans { get; }
}