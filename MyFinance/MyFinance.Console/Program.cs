using MyFinance.Domain.Entities;
using MyFinance.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product()
            {
                Name = "ProductAvecService",
                Price = 500,
                Description = "Nice Product",
                Quantity = 14,
                ImageUrl2 = "url",
                DateProd = new DateTime(2012,12,12)
            };
            Chemical chemProd = new Chemical()
            {
                Name = "Test Product",
                Price = 500,
                Description = "Nice Product",
                Quantity = 14,
                ImageUrl2 = "url",
                DateProd = new DateTime(0012, 12, 12),
                Address = new Address() {City ="New City" , StreetAddress = "New Address" }
                
            };
           
            Category cat = new Category()
            {
                Name = "New category"
            };
            /* 
             * Sans la couche Service
             //MyFinanceContext ctx = new MyFinanceContext();
            ctx.Categories.Add(cat);
           ctx.Products.Add(chemProd);
           ctx.Products.Add(prod);//Charger le dbSet des produits avec prod
           ctx.SaveChanges();//Synchronisation avec la base
           */
           //Avec la couche service
            IProductService prodService = new ProductService();

            prodService.AddProduct(prod);
          
            System.Console.WriteLine("END");
            System.Console.ReadKey();
            
        }
    }
}
