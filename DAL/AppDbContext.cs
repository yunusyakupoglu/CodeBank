using DAL.Configurations;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=connection")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SourceCode> SourceCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new SourceCodeConfiguration());
        }
    }
}
