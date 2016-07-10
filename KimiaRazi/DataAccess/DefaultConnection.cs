using KimiaRazi.Models;
using System.Data.Entity;

namespace KimiaRazi.DataAccess
{
    public class DefaultConnection:DbContext
    {
        public DefaultConnection()
            : base(){ }

        public DbSet<Product> Products { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}