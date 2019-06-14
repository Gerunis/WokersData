using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokersData
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DBConnectionString")
        {

        }

        public DbSet<Worker> Workers { get; set; }
    }
}
