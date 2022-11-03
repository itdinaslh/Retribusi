using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IDriver
{
    IQueryable<Driver> Drivers { get; }

    Task SaveDataAsync(Driver driver);
}
