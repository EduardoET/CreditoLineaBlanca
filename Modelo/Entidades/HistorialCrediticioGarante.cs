using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class HistorialCrediticioGarante
    {
        public int Id { get; set; }
        public int Puntaje { get; set; }
        public int DeudasActivas { get; set; }
        public int DeudasVencidas { get; set; }
        
    }
}
