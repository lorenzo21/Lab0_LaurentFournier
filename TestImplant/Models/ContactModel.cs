using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestImplant.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Requis")]
        public string Name { get; set; }

        [Required]
        [RegularExpression("@.*@")]
        public string Email { get; set; }

        [Required]
        public string Comments { get; set; }
    }
}