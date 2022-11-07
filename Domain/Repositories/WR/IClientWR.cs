using Retribusi.Entities;

namespace Retribusi.Repositories;

public interface IClientWR
{
    IQueryable<ClientWR> ClientWRs { get; }

    Task SaveDataAsync(ClientWR client);
}
