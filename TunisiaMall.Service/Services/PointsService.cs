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
    public class PointsService : Service<customer>, IPonitsService
    {
        private static IDatabaseFactory dbFactory = new DatabaseFactory();
        private static IUnitOfWork work = new UnitOfWork(dbFactory);
        public PointsService() : base(work) { }


        public void addPointsToCustomer(customer u, int points)
        {
            u = work.getRepository<customer>().FindById(u.idUser);
            u.points = u.points + points;
            work.getRepository<customer>().Update(u);
            work.Commit();
        }

        public void convertPoints(customer u, int points)
        {
            throw new NotImplementedException();
        }

        //getBestClient method takes the number of best clients you want to get
        //the clients are OrderByDescending by points number 
        public Dictionary<customer, int> getBestClient(int number)
        {
            Dictionary<customer, int> CustomerDic = new Dictionary<customer, int>();
            IEnumerable<customer> customers = GetMany().OrderByDescending(c => c.points).Take(number);
            foreach (var c in customers)
            {
                CustomerDic.Add(c, c.points);
            }

            return CustomerDic;
        }

        //this method removes Points From Customer
        public void removePointsFromCustomer(customer u, int points)
        {
            u = FindById(u.idUser);

            if (u.points > 0 && u.points > points)
            {
                // System.Diagnostics.Debug.WriteLine("points before---- + " + u.points);
                u.points = u.points - points;
                Update(u);
                work.Commit();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("points insuffisant");
            }

        }

        public void showAffordableGifts(customer u)
        {
            throw new NotImplementedException();
        }
    }
}
