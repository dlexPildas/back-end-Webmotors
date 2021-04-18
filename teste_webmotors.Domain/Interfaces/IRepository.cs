using System.Threading.Tasks;

namespace teste_webmotors.Data
{
    public interface IRepository : IRepositoryQuery
    {
        void Add<T>(T entity) where T : class;
        
        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;
        
        Task<bool> SaveChangesAsync();
    }
}