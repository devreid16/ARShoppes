using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARShoppes.Models
{
    public class Role
    {
        public int RoleID { get; set; }        
        public int DepartmentID { get; set; }
        public string Title { get; set; }

        public virtual Employee Employee { get; set; }
    }
}