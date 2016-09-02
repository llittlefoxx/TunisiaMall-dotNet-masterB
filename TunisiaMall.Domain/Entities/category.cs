using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class category
    {
        public int idCategory { get; set; }
        public string description { get; set; }
        public string libelle { get; set; }


        public ICollection<subcategory> subcategories { get; set; }
        public ICollection<shoprequest> shoprequests { get; set; }
        public ICollection<store> stores { get; set; }
    }
}
