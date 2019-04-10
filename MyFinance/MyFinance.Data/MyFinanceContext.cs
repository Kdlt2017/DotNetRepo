using MyFinance.Data.Configurations;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data
{
    public class MyFinanceContext:DbContext
    {
        public MyFinanceContext():base ("name=MaChaine")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        //Overriding the default configurations of the Database
        //so as to take into consideration the configurations
        //prepared in the CategoryConfiguration class
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }
    
}
