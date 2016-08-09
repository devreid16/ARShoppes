using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ARShoppes.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }
        public int DepartmentID { get; set; }       
        public int ProductUpc { get; set; }
        public string ProductDesc { get; set; }
        public int ProductQty { get; set; }
        public decimal ProductPrice { get; set; }
        public int PurchaseID { get; set; }
        public DateTime PurchaseDate { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
