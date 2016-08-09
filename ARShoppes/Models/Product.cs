using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ARShoppes.Models
{
    public class Product
    {        
        public int ProductID { get; set; }
        public string PrdName { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
