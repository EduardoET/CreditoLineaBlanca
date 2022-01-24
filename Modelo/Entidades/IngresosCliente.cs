using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class IngresosCliente
    {
        public int id { get; set; }
        public string Cliente { get; set; }
        public int Rol_Pagos_Netos { get; set; }
        public string Servicios_Basicos_Netos { get; set; }
        public string Ingresos_Totales { get; set; }

        // Relacion con Cliente
        public ICollection<Cliente> Clientes { get; set; }

        // Relacion con Rol de Pagos
        public ICollection<RoldePagos> RolPagos { get; set; }

    }
}
