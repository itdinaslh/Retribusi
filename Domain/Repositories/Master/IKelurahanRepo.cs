using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IKelurahanRepo {
    IQueryable<Kelurahan> Kelurahans { get; }
}