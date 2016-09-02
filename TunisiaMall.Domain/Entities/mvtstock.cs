using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class mvtstock
    {
        public int idMvt { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public string nature { get; set; }
        public int qte { get; set; }
        public int supplier { get; set; }
        public Nullable<int> idProduct { get; set; }
        public product product { get; set; }
    }
}
