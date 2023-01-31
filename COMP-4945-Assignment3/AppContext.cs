using System.Data.Entity;
using COMP_4945_Assignment3;
namespace COMP_4945_Assignment3.Models
{
    public class AppContext : DbContext
    {
        public AppContext()
        : base("DefaultConnection")
        {
        }
        public DbSet<Client> Clients { get; set; }
    }
}