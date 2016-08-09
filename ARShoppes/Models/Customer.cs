using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARShoppes.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime PurchaseDate { get; set; }

        //Navigation Properties
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}