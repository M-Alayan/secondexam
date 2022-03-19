using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondExam.data
{
    public class SEContext:DbContext
    {
        IConfiguration config;
        public SEContext(IConfiguration _config)
        {
            config = _config;
        }
      public  DbSet<Employee> employee { set; get; }
        public DbSet<Department> department { get; set; }

        public DbSet<Country> country { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("SE"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
