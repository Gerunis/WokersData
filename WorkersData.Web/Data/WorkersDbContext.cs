using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkersData.Web.Models;

namespace WorkersData.Web.Data
{
    public class WorkersDbContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Language> Languages { get; set; }

        public WorkersDbContext(DbContextOptions<WorkersDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
