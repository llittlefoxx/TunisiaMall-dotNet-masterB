using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class subcategory
    {
        public subcategory()
        {
            this.products = new List<product>();
        }

        public int idSubCategory { get; set; }
        public string description { get; set; }
        public string libelle { get; set; }
        public Nullable<int> idCategory { get; set; }


        public category category { get; set; }
        public ICollection<product> products { get; set; }
    }
}
