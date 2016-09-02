using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Domain.Entities;

namespace TunisiaMall.Service.Services
{
    public interface IOrderLineService
    {
        void addProductTOorder(orderline ol);
        List<orderline> getOrderLinesByOrder(order o);
        void deleteOrderLine(int idOrderLine);
        void editOrderLine(orderline ol);
        double getTotalOrder(order o);
    }
}
