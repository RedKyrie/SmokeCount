using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models.Entity
{
    public class Utente
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }
        [Required]
        [EmailAddress] //usiamo la mail anche come username
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Bisogna accettare la privacy")]
        public bool IsPrivacy { get; set; }
    }
}