using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalaoAutomovelI.Models;

namespace SalaoAutomovelI.Models
{
    public class Moto : Automovel
    {
        public Guid ClienteId { get; set; }
        //public Guid MarcaMotoId { get; set; }

        /* EF Relation */
        public IEnumerable<Cliente> Clientes { get; set; }

        //public IEnumerable<MarcaMoto> MarcaMotos { get; set; }

    }
}
