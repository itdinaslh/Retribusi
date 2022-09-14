using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IPegawai
{
    IQueryable<Pegawai> Pegawais { get; }

    Task SaveDataAsync(Pegawai peg);
}