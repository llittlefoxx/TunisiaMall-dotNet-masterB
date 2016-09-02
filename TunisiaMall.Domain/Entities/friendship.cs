using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class friendship
    {
        public int id { get; set; }
        public bool accepted { get; set; }
        public int idUser1 { get; set; }
        public int idUser2 { get; set; }
        public user user1 { get; set; }
        public user user2 { get; set; }
    }
}
