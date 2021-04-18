using System;
using System.Linq;
using System.Linq.Expressions;

namespace teste_webmotors.Data
{
    public interface IRepositoryQuery
    {
        IQueryable<T> Query<T>(params Expression<Func<T, object>>[] includeProperties) where T : class;
    }
}