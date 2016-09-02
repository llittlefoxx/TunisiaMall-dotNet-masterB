using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Infrastructure;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;
using TunisiaMall.Service.Services;

namespace TunisiaMall.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabaseFactory dbFactory = new DatabaseFactory();
            IUnitOfWork work = new UnitOfWork(dbFactory);
            // Services
            IMessageService messageService = new MessageService();

            /*List<message> ls = messageService.getMessagesForUser(1);
            Console.WriteLine(ls.Count());
            foreach(var m in ls)
            {
                Console.WriteLine("{0} {1}",m.idMessage, m.text);
            }*/
            //Console.WriteLine(userService.Athenticate("user1","esprit"));
            Console.ReadKey();
        }
    }
}
