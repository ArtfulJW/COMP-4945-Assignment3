﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP_4549_Assignment3.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Jobs> requestedJobs { get; set; }
    }
}