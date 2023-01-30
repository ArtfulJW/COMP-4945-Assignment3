using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP_4549_Assignment3.Models
{
    public class Employee : Person
    {
        public DateTime DOE { get; set; }
        public new int ID { get; set; }
    }
}