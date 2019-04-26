using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFinance.Presentation.Models
{
    public class ProductVM
    {

        [Display(Name = "Production Date")]
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(25, ErrorMessage = "User Input should be 25 characters")]
        [MaxLength(50, ErrorMessage = "Max length 50 characters")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public int ProductId { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        public string ImageUrl2 { get; set; }

        
    }
}