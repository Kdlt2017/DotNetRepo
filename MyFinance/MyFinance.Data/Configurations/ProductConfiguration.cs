using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Configurations
{
    public class ProductConfiguration:EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            
        }
    }
}
