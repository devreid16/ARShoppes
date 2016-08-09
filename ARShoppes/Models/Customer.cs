using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARShoppes.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int PurchaseID { get; set; }

        //Navigation Properties
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}