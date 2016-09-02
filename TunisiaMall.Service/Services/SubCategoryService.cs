using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Infrastructure;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;

namespace TunisiaMall.Service.Services
{
    public class SubCategoryService : Service<subcategory>, ISubCategoryService
    {

        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork utfk = new UnitOfWork(dbf);

        public SubCategoryService() : base(utfk){ }
    }
}
