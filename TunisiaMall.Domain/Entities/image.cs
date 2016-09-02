using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class image
    {
        public int idImage { get; set; }
        public string imagePath { get; set; }
        public Nullable<int> idProduct { get; set; }
        public product product { get; set; }
    }
}
