using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class orderline
    {
        public int idOrderLine { get; set; }
        public int qte { get; set; }
        public Nullable<int> idOrder_fk { get; set; }
        public Nullable<int> idProduct_fk { get; set; }
        public product product { get; set; }
        public order order { get; set; }
    }
}
