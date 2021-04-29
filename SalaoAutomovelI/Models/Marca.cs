using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalaoAutomovelI.Models
{
    public abstract class Marca
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(50, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 7)]
        public string Nome { get; set; }
    }
}
