using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class comment
    {
        public int idComment { get; set; }
        public DateTime commentDate { get; set; }
        public string text { get; set; }
        public int idPost { get; set; }
        public int idUser { get; set; }
        public post post { get; set; }
        public user user { get; set; }
    }
}
