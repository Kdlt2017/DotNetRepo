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
            //Many to Many Configuration
            HasMany(product => product.Providers).WithMany(provider => provider.Products)
                .Map(m=> {
                    m.ToTable("Providings");
                    m.MapLeftKey("Provider");
                    m.MapRightKey("Product");//Always the current Class
                          }
                    );
            //Inheritance Configuration(TPH:Table Per Hierachy)
            Map<Biological>(m => m.Requires("IsBiological").HasValue(1));//Requires changes the name of the discriminator column
            Map<Chemical>(m => m.Requires("IsBiological").HasValue(0));

            //OneToMany Configuration
            HasOptional(product => product.Category)
                .WithMany(category => category.Products)
                .HasForeignKey(product => product.CategoryId)
                .WillCascadeOnDelete(false);
        }
    }
}
