using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApplication_opcional_.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        void Save(T obj);
        void Save(List<T> obj);
        T FindById(int id);
        T Find(Expression<Func<T, bool>> predicate);
        ICollection<T> Get();
        ICollection<T> Get(Expression<Func<T, bool>> predicate);
        bool Delete(T obj);
        bool Delete(int id);
        void Dispose();
    }
}
