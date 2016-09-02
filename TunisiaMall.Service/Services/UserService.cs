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
    public class UserService : Service<user> , IUserService
    {
        // Attributes
        private static IDatabaseFactory dbFactory = new DatabaseFactory();
        private static IUnitOfWork work = new UnitOfWork(dbFactory);
        // Methods
        public UserService() : base(work){ }

        public bool Athenticate(string username, string password)
        {
            var user = GetMany(u => u.login == username && u.password == password);
            if (user.Count() == 1)
            {
                return true;
            }
            return false;
        }
        public int getUserIdByUsername(string name)
        {
            // return work.getRepository<user>().GetMany(u => u.login == name).First().idUser ;
            return 1;
        }
    }
}
