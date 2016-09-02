using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Models;

namespace TunisiaMall.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        // Attributes
        private tunisiamallContext dataContext;
        public tunisiamallContext DataContext
        {
            get
            {
                return dataContext;
            }
        }
        // Methods
        public DatabaseFactory()
        {
            dataContext = new tunisiamallContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }
}
