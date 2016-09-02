using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class order
    {
        public order()
        {
            this.orderlines = new List<orderline>();
        }

        public int idOrder { get; set; }
        public Nullable<decimal> amountPayed { get; set; }
        public string cardHolder { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.DateTime> datePay { get; set; }
        public string orderStatus { get; set; }
        public string statusPayment { get; set; }
        public Nullable<int> idUser { get; set; }
        public ICollection<orderline> orderlines { get; set; }
        public user user { get; set; }
    }
}
