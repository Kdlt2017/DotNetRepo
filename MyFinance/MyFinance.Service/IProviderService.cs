﻿using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service
{
  public  interface IProviderService
    {
         void AddProvider(Provider prov);
    }
}
