using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Domain.Entities;

namespace TunisiaMall.Domain.Entities
{
   public class shopowner: user
    {
        public Nullable<System.DateTime> dateActivation { get; set; }
    }
}
