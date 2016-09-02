using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class promotionsuggest
    {
        public promotionsuggest()
        {
            this.products = new List<product>();
        }

        public int idPromotionSuggest { get; set; }
        public string desccription { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> suggestionDate { get; set; }
        public double value { get; set; }
        public ICollection<product> products { get; set; }
    }
}
