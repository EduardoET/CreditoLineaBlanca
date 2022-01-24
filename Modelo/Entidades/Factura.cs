using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Factura
    {
        public int FacturaId { get; set; }

        public int TotaldeCompra { get; set; }

        //relacion con cliente
        public ICollection<Cliente> Clientes { get; set; }

        //relacion con Producto
        public ICollection<Producto> Productos { get; set; }

       


    }
}
