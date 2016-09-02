
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Infrastructure;

namespace TunisiaMall.Service.Pattern
{
    public class Service<T> : IService<T> where T : class
    {
        // Attributes
        private IUnitOfWork work;
        // Methods
        protected Service(IUnitOfWork work)
        {
            this.work = work;
        }

        public void Commit()
        {
            try
            {
                work.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            work.Dispose();
        }

        public void Create(T e)
        {
            work.getRepository<T>().Create(e);
        }

        public void Delete(Expression<Func<T, bool>> condition)
        {
            work.getRepository<T>().Delete(condition);
        }

        public void Delete(T e)
        {
            work.getRepository<T>().Delete(e);
        }

        public T FindById(long id)
        {
            return work.getRepository<T>().FindById(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderBy = null)
        {
            return work.getRepository<T>().GetMany(condition, orderBy);
        }

        public void Update(T e)
        {
            work.getRepository<T>().Update(e);
        }
    }
}
