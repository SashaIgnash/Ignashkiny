using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCS
{
    class Context : DbContext

    {
        public DbSet<Products> ProductsList{ get; set; }
        public DbSet<Orders> OrdersList { get; set; }
    }
}
