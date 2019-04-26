using MyFinance.Data;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    public class ProviderService:IProviderService
    {
        MyFinanceContext ctx;
        public ProviderService()
        {
            ctx = new MyFinanceContext();
        }
      public void AddProvider(Provider prov) {
            ctx.Providers.Add(prov);
            ctx.SaveChanges();
        }
    }
}
