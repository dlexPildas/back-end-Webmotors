using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using teste_webmotors.Domain.Models.AnuncioWebmotorsAgregates.Entities;

namespace teste_webmotors.Data.Data
{
    public class DataContext : DbContext, IRepository
    {
        public DbSet<AnuncioWebmotors> AnuncioWebmotors { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }

        public void Add<T>(T entity) where T : class
        {
            base.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            base.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            base.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await base.SaveChangesAsync()) > 0;
        }

        public IQueryable<T> Query<T>(params Expression<Func<T, object>>[] includeProperties) where T : class
        {
            var query = base.Set<T>().AsQueryable();

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                    query = query.Include<T, object>(includeProperty);
            }

            return query;
        }
    }
}
