using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Provider
    {
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Key]
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public string Username { get; set; }
        //Navigation properties
        public virtual ICollection<Product> Products { get; set; }
    }
}
