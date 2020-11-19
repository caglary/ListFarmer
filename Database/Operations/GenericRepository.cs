using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace Database.Operations
{
    public class GenericRepository<T> where T : class
    {
        public virtual int Add(T item)
        {
            using (Context.DbTarimContext db = new Context.DbTarimContext())
            {
                DbSet<T> table = db.Set<T>();
                table.Add(item);
                return db.SaveChanges();
            }
        }
        public virtual int Update(T item)
        {
            using (Context.DbTarimContext db = new Context.DbTarimContext())
            {
                db.Entry(item).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
        public virtual int Delete(Expression<Func<T, bool>> parametre)
        {
            using (Context.DbTarimContext db = new Context.DbTarimContext())
            {
                var query = db.Set<T>().Where(parametre).FirstOrDefault();
                if (query != null)
                {
                    db.Set<T>().Remove(query);
                }
                return db.SaveChanges();
            }
        }
        public virtual IEnumerable<T> GetAll()
        {
            using (Context.DbTarimContext db = new Context.DbTarimContext())
            {
                DbSet<T> table = db.Set<T>();
                return table.ToList();
            }
        }
        public virtual T Get(Expression<Func<T, bool>> predicate)
        {
            using (Context.DbTarimContext db = new Context.DbTarimContext())
            {
                DbSet<T> table = db.Set<T>();
                return table.Where(predicate).FirstOrDefault();
            }
        }
    }
}
