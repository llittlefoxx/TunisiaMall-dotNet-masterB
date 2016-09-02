using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class gestbookentry
    {

        public gestbookentry() {
            this.dateEntrie = DateTime.Now.Date;
            this.rating = 0;
            this.user_idUser = 2;

        }


        public int idEntries { get; set; }
        public Nullable<System.DateTime> dateEntrie { get; set; }
        public int rating { get; set; }
        public string text { get; set; }
        public int? user_idUser { get; set; }
        public user user { get; set; }
    }
}
