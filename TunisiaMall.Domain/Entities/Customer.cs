using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunisiaMall.Domain.Entities
{
    public class customer: user
    {
        public string facturationAddr { get; set; }
        public string shipementAddr { get; set; }
        public int points { get; set; }
    }
}
