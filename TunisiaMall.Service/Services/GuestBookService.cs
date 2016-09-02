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
    public class GuestBookService: Service<gestbookentry> , IGuestBookService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork utfk = new UnitOfWork(dbf);

        public GuestBookService() : base(utfk){ }

        public IEnumerable<gestbookentry> GetGuestBookOrderByDate()
        {
           return utfk.getRepository<gestbookentry>().GetMany().OrderBy(g=> g.dateEntrie);
        }

        public IEnumerable<gestbookentry> GetGuestBookEntryByKeyword(string keyword)
        {
            var rest = from entry in dbf.DataContext.gestbookentries
                       where entry.text.Contains(keyword)
                       select entry;
            return rest;
        }

        public IEnumerable<gestbookentry> GetGuestBookEntryByDate(DateTime date)
        {
            var rest = from entry in dbf.DataContext.gestbookentries
                       where entry.dateEntrie == date
                       select entry;
            return rest;
        }

        public IEnumerable<gestbookentry> FindGuestBookEntry(DateTime date, string keyword)
        {
            IEnumerable<gestbookentry> list;
            ICollection<gestbookentry> list2 = null;
            list = GetGuestBookEntryByDate(date);
            foreach (var item in list)
            {
                if (item.text.Contains(keyword))
                {
                    list2.Add(item);
                }
            }
            return list2;

        }
    }
}
