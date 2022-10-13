using Retribusi.Entities;

namespace Retribusi.Repositories
{
    public interface IStatusLahan
    {
        IQueryable<StatusLahan> StatusLahans { get; }

        Task SaveDataAsync(StatusLahan status);

    }
}
