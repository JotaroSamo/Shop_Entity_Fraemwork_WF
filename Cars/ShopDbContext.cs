using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cars
{
    class DetalDbContext : DbContext
    {
        public DetalDbContext() : base("DbConnectionString")
        {
            
        }
        public DbSet<Price> Prices { get; set; }
        public DbSet<UserAnd_Admin> userAnds { get; set; }
        public DbSet<Basket> baskets { get; set; }
    }
}
