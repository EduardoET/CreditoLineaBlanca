using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class RoldePagos
    {
        public int Id { get; set; }
        public string Cliente { get; set; }

        public string Cargo { get; set; }

        public decimal Sueldo { get; set; }
        public int Horas_extra { get; set; }

        public decimal AporteIEES { get; set; }

        public decimal Total { get; set; }

        // Relacion con Cliente
        public ICollection<Cliente> Clientes { get; set; }
    }
}
