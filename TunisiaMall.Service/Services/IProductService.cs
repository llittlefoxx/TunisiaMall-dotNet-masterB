using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;

namespace TunisiaMall.Service.Services
{
    public interface IProductService : IService<product>
    {
        IEnumerable<product> getAll();
        product getProdByID(int id);
        IEnumerable<product> findByLibelle(string lib);

        
    }
}
