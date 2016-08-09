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
        public int DepartmentID { get; set; }
        public string EmpLName { get; set; }
        public string EmpFName { get; set; }
        public string Title { get; set; }
        public DateTime HireDate { get; set; }

        //Navigation Properties
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}