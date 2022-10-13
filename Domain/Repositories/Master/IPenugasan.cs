using Retribusi.Entities;

namespace Retribusi.Repositories
{
    public interface IPenugasan
    {
        IQueryable<Penugasan> Penugasans { get; }

        Task SaveDataAsync(Penugasan tugas);
    }
}
