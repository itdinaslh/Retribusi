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
        } else
        {
            ClientWR? data = await context.ClientWRs.FindAsync(client.ClientId);

            if (data != null)
            {
                data.JenisID = client.JenisID;
                data.ObjectName = client.ObjectName;
                data.ObjectPhone = client.ObjectPhone;
                data.Alamat = client.Alamat;
                data.KecamatanID = client.KecamatanID;
                data.KelurahanID = client.KelurahanID;
                data.Longitude = client.Longitude;
                data.Latitude = client.Latitude;
                data.ClientName = client.ClientName;
                data.ClientNIK = client.ClientNIK;
                data.ClientNPWP = client.ClientNPWP;
                data.ClientPhone = client.ClientPhone;
                data.PegawaiId = client.PegawaiId;
                data.StatusAktif = client.StatusAktif;

                context.Update(data);
            }
        }

        await context.SaveChangesAsync();
    }
}
