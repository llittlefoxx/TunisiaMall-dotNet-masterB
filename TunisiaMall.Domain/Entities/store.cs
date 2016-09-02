using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities

{
    public partial class store
    {
        public int idStroe { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> openingDay { get; set; }
        public string status { get; set; }
        public string tel { get; set; }
        public int? category_fk { get; set; }
        public int? idUser { get; set; }


        public category category { get; set; }
        public ICollection<product> products { get; set; }
        public user user { get; set; }
        public ICollection<Event> events { get; set; }
    }
}
