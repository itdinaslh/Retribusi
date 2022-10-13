using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IBidangRepo {
    IQueryable<Bidang> Bidangs { get; }

    Task SaveBidangAsync(Bidang bidang);
}