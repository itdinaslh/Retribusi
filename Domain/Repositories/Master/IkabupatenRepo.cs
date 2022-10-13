using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IKabupatenRepo {
    IQueryable<Kabupaten> Kabupatens { get; }
}