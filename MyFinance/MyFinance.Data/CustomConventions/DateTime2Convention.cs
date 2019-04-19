using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.CustomConventions
{
    public class DateTime2Convention:Convention
    {
        public DateTime2Convention()
        {
            Properties<DateTime>()
                .Configure(p => p.HasColumnType("datetime2"));

        }
    }
}
