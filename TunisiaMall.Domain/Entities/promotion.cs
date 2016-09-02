using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class promotion
    {
        public promotion()
        {
            this.products = new List<product>();
        }

        public long idPromotion { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public bool state { get; set; }
        public double value { get; set; }
        public ICollection<product> products { get; set; }
    }
}
