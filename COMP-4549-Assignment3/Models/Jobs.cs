using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COMP_4549_Assignment3.Models
{
    public class Jobs
    {
        [Key]
        public int JobID { get; set; }
        public int ClientID { get; set; }
        public int ServiceID { get; set; }


        public virtual Client Client { get; set; }
        public virtual Service Service { get; set; }
    }
}