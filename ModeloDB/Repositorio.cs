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
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<EgresoCliente> EgresoClientes { get; set; }
        public DbSet<Factura> facturas { get; set; }
        public DbSet<Garante> Garantes  { get; set; }
        public DbSet<HistorialCrediticioExterno> HistorialCrediticioExternos { get; set; }
        public DbSet<HistorialCrediticioGarante> HistorialCrediticioGarantes { get; set; }
        public DbSet<HistorialCrediticioInterno> HistorialCrediticioInternos { get; set; }
        public DbSet<IngresosCliente> ingresosClientes { get; set; }
        public DbSet<RoldePagos> RoldePagos { get; set; }


        //configuracion de la conexion 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data source = DESKTOP - 9D8KVK4; Integrated Security = true; Initial Catalog = LineaBlanca; ");
        }



    }
}
