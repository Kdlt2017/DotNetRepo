using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    //Ne contiennent pas de cle primaire
    //Ne contient pas de type complex
    //L'appel se fait en instance unique
    public class Address
    {
        public string City { get; set; }
        public string StreetAddress { get; set; }
    }
}
