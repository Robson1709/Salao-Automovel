using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalaoAutomovelI.Models
{
    public abstract class Automovel 
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(7, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 7)]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public string Ano { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(20)]
        public string Cor { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public int KM { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [DisplayName("Tipo Câmbio")]
        public TipoCambio TipoCambio { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [DisplayName("Combustível")]
        public TipoCombustivel TipoCombustivel { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [DisplayName("Preço Compra")]
        public decimal PrecoCompra { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [DisplayName("Preço Venda")]
        public decimal PrecoVenda { get; set; }

        /* EF Relation */
        public Cliente Cliente { get; set; }
    }
}
