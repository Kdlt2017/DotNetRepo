using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Domain.Entities;
using MyFinance.Data;

namespace MyFinance.Service
{
    public class ProductService : IProductService
    {
        MyFinanceContext ctx;
        public ProductService()
        {
            ctx = new MyFinanceContext();
        }
        public void AddProduct(Product prod)
        {
            ctx.Products.Add(prod);
            ctx.SaveChanges();
        }

        public IEnumerable<Product> ListProducts()
        {
            return ctx.Products.AsEnumerable();
        }
    }
}
