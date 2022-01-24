using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class HistorialCrediticioInterno
    {
        public int Id { get; set; }
        public int Puntaje { get; set; }
        public int DeudasActivas { get; set; }
        public int DeudasVencidas { get; set; }
        // Relacion con Cliente
        public ICollection<Cliente> Clientes { get; set; }
    }
}
