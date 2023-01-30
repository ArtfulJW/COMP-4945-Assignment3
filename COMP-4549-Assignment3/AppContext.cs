using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using COMP_4549_Assignment3.Models;

namespace COMP_4549_Assignment3
{
    public class AppContext : DbContext
    {
        public AppContext()
        : base("Database1")
        {
        }
        public DbSet<Client> Client { get; set; }
    }
}
