namespace proiectDaw.Data.UitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> SaveAsync();
    }
}
