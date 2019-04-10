using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
   public class Product
    {
        [Display(Name="Production Date")]
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage ="This field is required")]
        [StringLength(25, ErrorMessage ="User Input should be 25 characters")]
        [MaxLength(50, ErrorMessage ="Max length 50 characters")]
        public string Name { get; set; } 
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public int ProductId { get; set; }
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }
        public string ImageUrl2 { get; set; }
        
        public int? CategoryId { get; set; }//?: nullable


        //Les proprietes de navigation
        //virtual :Distinguishes in between navigation properties and basic properties
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }

    }
}
