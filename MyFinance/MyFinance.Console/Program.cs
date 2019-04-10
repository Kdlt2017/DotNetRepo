using MyFinance.Data;
using MyFinance.Domain.Entities;
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
                Name = "My Product",
                Price = 500,
                Description = "Nice Product",
                Quantity = 14,
                ImageUrl2 = "url",
                DateProd = new DateTime(2012,12,12)
            };
            MyFinanceContext ctx = new MyFinanceContext();
            Category cat = new Category()
            {
                Name = "New category"
            };
            ctx.Categories.Add(cat);
            ctx.Products.Add(prod);//Charger le dbSet des produits avec prod
            ctx.SaveChanges();//Synchronisation avec la base

            System.Console.WriteLine("END");
            System.Console.ReadKey();
            
        }
    }
}
