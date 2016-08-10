using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ARShoppes.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PurchaseDate { get; set; }
        public int PurchaseID { get; set; }

        //Navigation Properties
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}