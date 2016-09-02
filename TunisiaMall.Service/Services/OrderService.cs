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
    public class OrderService :Service<order> , IOrderService
    { 
        private static IDatabaseFactory dbFactory = new DatabaseFactory();
        private static IUnitOfWork work = new UnitOfWork(dbFactory);
        PointsService ps = new PointsService();
        UserService us = new UserService();
        public OrderService() : base(work){ }

   

        public int createOrder(order o)
        {
            work.getRepository<order>().Create(o);
            work.Commit();
            ps.addPointsToCustomer((customer)us.FindById((long)o.idUser)
                , (int)o.amountPayed/10);
            return finOrderByDate();
        }
        public int finOrderByDate()
        {
            return work.getRepository<order>().GetMany().Max(t=>t.idOrder) ;

        }

        public void editOrder(order o)
        {
            work.getRepository<order>().Update(o);
            work.Commit();
        }
        // the method getOrdersByCustomer allows you to return 
        //all orders by all customers if nothing is given as parameter
        //if a customer is givin as a parameter the method returns orders performed 
        //only by this customer
        public IEnumerable<customerOrders> getOrdersByCustomer(customer c = null)
        {
            IEnumerable<customerOrders> finalResult = null;

            if (c != null)
            {
                var result = from order in GetMany()
                             where order.idUser == c.idUser
                             group order by order.idUser into a
                             select new customerOrders
                             {
                                 idu = c.idUser,
                                 orders = a.ToList()
                             };

                foreach (var item in result)
                {
                    System.Diagnostics.Debug.WriteLine("customer " + item.idu);
                    foreach (var order in item.orders)
                    {
                        System.Diagnostics.Debug.WriteLine("    id order " + order.idOrder);
                    }
                }
                finalResult = (IEnumerable<customerOrders>)result;
            }
            else
            {

                var res = from order in GetMany()
                          group order by order.idUser into a
                          select new customerOrders
                          {
                              idu = (int)a.Key,
                              orders = a.ToList()
                          };
                foreach (var item in res)
                {
                    System.Diagnostics.Debug.WriteLine("customer " + item.idu);
                    foreach (var item2 in item.orders)
                    {
                        System.Diagnostics.Debug.WriteLine("orders " + item2.idOrder);
                    }
                }
                finalResult = (IEnumerable<customerOrders>)res;

            }
            return finalResult;
        }

        public void removeOrder(order o)
        {
            OrderLineService ords = new OrderLineService();

            ords.deleteOrderLinesByOrder(o.idOrder);
            o = work.getRepository<order>().FindById(o.idOrder);
            work.getRepository<order>().Delete(o);
            work.Commit();
        }

        //the method allows you to update the paymenet status of a existing order 
        //or create a new order and specifying it's payement status 
        //status ==0 =>unpaid / status ==0 =>paid
        public void saveAsUnpaiedOrderOrUnpaid(order o, int status)
        {
            order existingOrder = new order();
            // try to find if the order allready exist
            existingOrder = work.getRepository<order>().FindById(o.idOrder);
            //if the order exists
            if (existingOrder != null)
            {
                if (status == 0)
                {
                    existingOrder.statusPayment = "unpaid";

                }
                else if (status == 1)
                {
                    existingOrder.statusPayment = "paid";
                }
                editOrder(existingOrder);

            }

            else {
                if (status == 0)
                {
                    o.statusPayment = "unpaid";
                }
                else if (status == 1)
                {
                    o.statusPayment = "paid";
                }

                createOrder(o);
            }


        }
    }
    //this class is used to join customers and orders
    public class customerOrders
    {
        public int idu { get; set; }
        public List<order> orders { get; set; }
    }
}
