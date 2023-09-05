using CvProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace CvProject.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        CvProjectEntities db = new CvProjectEntities();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        public void TAdd(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }

        public void TRemove(T item)
        {
            db.Set<T>().Remove(item);
            db.SaveChanges();
        }

        public T TGetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void TUpdate(T item)
        {

            db.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}