using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace School.Controller
{
    public interface IDataRepo<T>
    {
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        T Get(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        void Update(T item);
        void Add(T item);
        void Delete(T item);
    }
}
