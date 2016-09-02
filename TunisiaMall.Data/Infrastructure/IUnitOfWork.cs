
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  TunisiaMall.Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> getRepository<T>() where T : class; //  return instance des RepositoryBase
        void Commit();
    }
}
