using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Domain.Entities;

namespace TunisiaMall.Service.Services
{
    public interface IOrderService
    {
        int  createOrder(order o);
        void removeOrder(order o);
        void saveAsUnpaiedOrderOrUnpaid(order o, int status);
        void editOrder(order o);
        IEnumerable<customerOrders> getOrdersByCustomer(customer c = null);
     
    }
 
}
