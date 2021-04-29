using System;
using System.ComponentModel.DataAnnotations;

namespace SalaoAutomovelI.Models
{
    public class Cliente 
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(14)]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(11)]
        public string Telefone { get; set; }
    }
}