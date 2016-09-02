using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class Event
    {
        public int idEvent { get; set; }
        public Nullable<System.DateTime> dateEvent { get; set; }
        public string description { get; set; }
        public int periodEvent { get; set; }
        public string titleEvent { get; set; }
        public string typeEvent { get; set; }
        public ICollection<subscription> subscriptions { get; set; }
        public ICollection<store> stores { get; set; }
    }
}
