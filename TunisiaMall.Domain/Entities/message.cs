using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class message
    {
        public int idMessage { get; set; }
        public System.DateTime date { get; set; }
        public string text { get; set; }
        public int idUserReciver_fk { get; set; }
        public int idUserSender_FK { get; set; }
        public virtual user reciver { get; set; }
        public virtual user sender { get; set; }
    }
}
