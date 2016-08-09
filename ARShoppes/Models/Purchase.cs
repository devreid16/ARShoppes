﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARShoppes.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int DepartmentID { get; set; }
        public int EmployeeID { get; set; }
        public decimal SaleTotal { get; set; }


        //Navigation Properties
        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }

    }
}