using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    internal class Repositorio: DbContext 
    {
        public DbSet<Producto> Productos { get; set; }
    }
}
