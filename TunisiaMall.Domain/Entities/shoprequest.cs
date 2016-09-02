using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class shoprequest
    {
        public int idRequest { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public string description { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string job { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public Nullable<System.DateTime> plannedOpeningDate { get; set; }
        public Nullable<System.DateTime> rcptDate { get; set; }
        public Nullable<int> rentPeriod { get; set; }
        public bool status { get; set; }
        public bool storeInMall { get; set; }
        public Nullable<int> category_fk { get; set; }
        public category category { get; set; }
    }
}
