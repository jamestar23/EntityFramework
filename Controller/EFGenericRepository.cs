using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace School.Controller
{
    public class EFGenericRepository<T> : IDataRepo<T> where T : class //: ISoftDelete
    {
        private SchoolContext _context;
        public EFGenericRepository()
        {
            _context = new SchoolContext();
        }

        public void Add(T item)
        {
            //_context.Students.Add(new StudentPoco()); //without generics
            _context.Entry(item).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(T item)
        {
            //var x = _context.Entry(item).Entity;
            //x.IsDeleted = true;
            //Update(x);

            _context.Entry(item).State = EntityState.Deleted;
            _context.SaveChanges(); //nothing is committed in the DB unless this is executed
        }

        public T Get(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = _context.Set<T>();
            foreach (Expression<Func<T, object>> navProp in navigationProperties)
            {
                dbQuery = dbQuery.Include<T, object>(navProp);
            }
            var result = dbQuery.FirstOrDefault(where);   //dbQuery.Where(where).FirstOrDefault();

            return result;
        }

        public IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = _context.Set<T>();
            foreach (var navProp in navigationProperties)
            {
                dbQuery = dbQuery.Include<T, object>(navProp);
            }
            return dbQuery.ToList();
        }

        public IList<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties) //returns an items from 'Where'
        {
            IQueryable<T> dbQuery = _context.Set<T>();
            foreach (var navProp in navigationProperties)
            {
                dbQuery = dbQuery.Include<T, object>(navProp);
            }
            return dbQuery.Where(where).ToList();
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
