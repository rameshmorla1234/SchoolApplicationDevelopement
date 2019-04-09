using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EODAL.Models;
namespace EODAL.Context
{
  public  class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GLT028\\SQLEXPRESS;database=EducationalOrganization.Database;user=sa;password=Ram@2019;", p => p.MigrationsAssembly("GateWay"));
        }
    }
}
