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
    public class OrderLineService : Service<orderline>, IOrderLineService
    {

        // Attributes
        private static IDatabaseFactory dbFactory = new DatabaseFactory();
        private static IUnitOfWork work = new UnitOfWork(dbFactory);
        public OrderLineService() : base(work) { }

        public void addProductTOorder(orderline ol)
        {
            work.getRepository<orderline>().Create(ol);
            work.Commit();

        }

        public void deleteOrderLine(int idOL)
        {
            orderline ol = work.getRepository<orderline>().FindById(idOL);
            work.getRepository<orderline>().Delete(ol);
            work.Commit();
        }

        public void editOrderLine(orderline ol)
        {
            work.getRepository<orderline>().Update(ol);
            work.Commit();
        }

        //this method returns a list of orderlines depending on the order passed as parameter
        public List<orderline> getOrderLinesByOrder(order o)
        {
            List<orderline> result;
            result = (List<orderline>)
                work.getRepository<orderline>().GetMany(t => t.idOrder_fk == o.idOrder).
                GroupBy(t => t.idProduct_fk).
                Select(c => new orderline
                {
                    idProduct_fk = (int)c.First().idProduct_fk,
                    qte = c.Sum(c1 => c1.qte),
                }).ToList();

            System.Diagnostics.Debug.WriteLine("order : " + o.idOrder);
            foreach (var item in result)
            {
                System.Diagnostics.Debug.WriteLine("    PROD :  " + item.idProduct_fk + " QTE :  " + item.qte);
            }


            return result;
        }
        public void deleteOrderLinesByOrder(int idOrder)
        {
            OrderService orderService = new OrderService();
            order order = new order();
            if (orderService.FindById(idOrder) != null)
            {
                order = orderService.FindById(idOrder);

                foreach (var item in order.orderlines)
                {
                    work.getRepository<orderline>().Delete(work.getRepository<orderline>().FindById(item.idOrderLine));
                    work.Commit();

                }
            }
        }

        public double getTotalOrder(order o)
        {
            double total = 0;
            List<orderline> lines = getOrderLinesByOrder(o);
            ProductService ps = new ProductService();
            foreach (var orderline in lines)
            {
                product prod = ps.getProdByID((int)orderline.idProduct_fk);
                total = total + (prod.sellPrice) * orderline.qte;
            }
            System.Diagnostics.Debug.WriteLine(" total order " + o.idOrder + " : " + total);
            return total;
        }
    }
}
