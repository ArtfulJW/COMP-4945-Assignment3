using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP_4549_Assignment3.Models
{
    public class Employee : Person
    {
        public int EmployeeID { get; set; }
        public DateTime DOE { get; set; }
        
    }
}