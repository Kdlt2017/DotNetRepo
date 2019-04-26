using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFinance.Presentation.Models
{
    public class ProviderVM
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
       
        public bool IsApproved { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public string Username { get; set; }
    }
}