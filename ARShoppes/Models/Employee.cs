using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARShoppes.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int RoleID { get; set; }
        public int PurchaseID { get; set; }
        public string EmpLName { get; set; }
        public string EmpFName { get; set; }
        public string EmpTitle { get; set; }
        public DateTime EmpHireDate { get; set; }

        //Navigation Properties
        public virtual ICollection<Purchase> Purchases { get; set; }
        
    }
}