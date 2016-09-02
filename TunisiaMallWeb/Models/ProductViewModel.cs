using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TunisiaMallWeb.Models
{
    public class ProductViewModel
    {
        public int idproduct { get; set; }
        [Display(Name = "Libelle")]
        public string libelleview { get; set; }
        [Display(Name = "Quantite")]
        public int qteview { get; set; }
        [Display(Name = "Price")]
        public double price { get; set; }
        [Display(Name = "Promotion")]
        public string promotionName { get; set; }
        [Display(Name = "Promotion % ")]
        public double promoVal { get; set; }
    }
}