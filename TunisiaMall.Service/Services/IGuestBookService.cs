using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;

namespace TunisiaMall.Service.Services
{
    public interface IGuestBookService: IService<gestbookentry>
    {
        IEnumerable<gestbookentry> GetGuestBookOrderByDate();
        IEnumerable<gestbookentry> GetGuestBookEntryByKeyword(string keyword);
        IEnumerable<gestbookentry> GetGuestBookEntryByDate(DateTime date);

        IEnumerable<gestbookentry> FindGuestBookEntry(DateTime date, string keyword);
    }
}
