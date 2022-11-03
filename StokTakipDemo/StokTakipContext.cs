using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipDemo
{
    public class StokTakipContext:DbContext
    {
        public DbSet<Product> Products1 { get; set; }
    }
}
