using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;

namespace TunisiaMall.Service.Services
{
    public interface IStoreService : IService<store>
    {
        IEnumerable<store> GetStoreByCategory(string cat);
        IEnumerable<store> GetStoreBySubCategory(string subcategoryName);
        IEnumerable<store> GetStoreByPromotionProduct();

        IEnumerable<store> GetStoreByEvent(string titleEvent);

        store GetStoreByName(string nom);
        IEnumerable<product> GetProductByPromotionStore(int id);

    }
}
