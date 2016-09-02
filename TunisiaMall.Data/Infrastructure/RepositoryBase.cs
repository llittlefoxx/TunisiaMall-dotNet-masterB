
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Models;

namespace  TunisiaMall.Data.Infrastructure
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        // Attributes
        private IDatabaseFactory databaseFactory;
        private tunisiamallContext dataContext;
        private readonly IDbSet<T> dbset;
        public tunisiamallContext DataContext
        {
            get
            {
                return dataContext = databaseFactory.DataContext;
            }
        }
        // Methods
        public RepositoryBase(IDatabaseFactory dbFactory)
        {
            this.databaseFactory = dbFactory;
            this.dbset = DataContext.Set<T>();
        }
        
        public virtual void Create(T e)
        {
            dbset.Add(e);
        }

        public virtual void Delete(System.Linq.Expressions.Expression<Func<T, bool>> condition)
        {
            IEnumerable<T> list = dbset.Where<T>(condition).AsEnumerable();
            foreach (T t in list)
            {
                dbset.Remove(t);
            }
        }

        public void Delete(T e)
        {
            dbset.Remove(e);
        }

        public virtual T FindById(long id)
        {
            return dbset.Find(id);
        }

        public virtual IEnumerable<T> GetMany(System.Linq.Expressions.Expression<Func<T, bool>> condition = null, System.Linq.Expressions.Expression<Func<T, bool>> orderBy = null)
        {
            IQueryable<T> list = dbset; // on ne peut mettre les dbset que dans IQueryable parce que en réalité ce sont des tables 
            // de la base 
            if (condition != null)
                return list.Where(condition);
            if (orderBy != null)
                return list.OrderBy(orderBy);
            else return list;
        }

        public virtual void Update(T e)
        {
            dbset.Attach(e); // appler l'objet e et l'attecher au context pour qu'on puisse le modifier 
            DataContext.Entry(e).State = EntityState.Modified; // modification de l'objet 
        }
    }
}
