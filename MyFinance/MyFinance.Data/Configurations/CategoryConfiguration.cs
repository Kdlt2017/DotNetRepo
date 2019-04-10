using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Configurations
{//This is the fluent api configuration 
    public class CategoryConfiguration:EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("MyCategories");
            HasKey(p => p.CategoryId);
            Property(p => p.Name).HasMaxLength(50);
        }
    }
}
