using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SalaoAutomovelI.Models
{
    public class Carro : Automovel
    {
        public Guid ClienteId { get; set; }

        [DisplayName("Carroceria")]
        public TipoCarroceria TipoCarroceria { get; set; }
        //public Automovel Automovel { get; set; }

        /* EF Relation */
        public IEnumerable<Cliente> Clientes { get; set; }
    }
}
