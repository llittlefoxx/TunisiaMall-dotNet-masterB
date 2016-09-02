using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Models;

namespace TunisiaMall.Data.Infrastructure
{
    public interface IDatabaseFactory
    {
        tunisiamallContext DataContext { get; }
    }
}
