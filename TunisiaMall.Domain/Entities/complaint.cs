using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class complaint
    {
        public int idComplaint { get; set; }
        public Nullable<System.DateTime> complaintDate { get; set; }
        public string nature { get; set; }
        public string text { get; set; }
        public Nullable<int> idUser { get; set; }
        public user user { get; set; }
    }
}
