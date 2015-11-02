using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ProjectTracking.Data.Infrastructure
{
    public interface IRepository <T> : IDisposable
    {
        IEnumerable<T> GetAll { get; }
        IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        T Find(int id);
        void InsertOrUpdate(T entity);
        void Delete(int id);
        void Save();

    }
}
