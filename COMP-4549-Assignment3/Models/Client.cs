using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace COMP_4549_Assignment3.Models
{
    public class Client : Person
    {
        public int ClientID { get; set; }
    }
}