using Retribusi.Data;
using Retribusi.Entities;
using Retribusi.Repositories;

namespace Retribusi.Services;

public class ClientWRService : IClientWR
{
    private readonly AppDbContext context;

    public ClientWRService(AppDbContext context)
    {
        this.context = context;
    }

    public IQueryable<ClientWR> ClientWRs => context.ClientWRs;

    public async Task SaveDataAsync(ClientWR client)
    {
        if (client.ClientId == Guid.Empty)
        {
            await context.AddAsync(client);
        }

        await context.SaveChangesAsync();
    }
}
