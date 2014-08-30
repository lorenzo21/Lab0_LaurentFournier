using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestImplant.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Nom requis")]
        public string Nom { get; set; }

        [Required]
        [RegularExpression(@".*@.*", ErrorMessage="Veuillez inscrire un email valide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Commentaire requis")]
        public string Commentaires { get; set; }
    }
}