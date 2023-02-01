using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COMP_4549_Assignment3.Models
{
    public class Employee : Person
    {
        [Key]
        public int EmployeeID { get; set; }
        
        public DateTime DOE { get; set; }
        public int ServiceID { get; set; }
        public virtual Service Service { get; set; }
        
    }
}