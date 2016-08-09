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
        public int DepartmentID { get; set; }
        public string PrdUpc { get; set; }
        public string PrdDesc { get; set; }
        public int PrdQty { get; set; }
        public decimal PrdPrice { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
