using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ARShoppes.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }        
        public string DeptName { get; set; }
        public string MgrFName { get; set; }
        public string MgrLName { get; set; }

        //Navigation Properties
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}