using Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lista de productos 
            Producto Refreigeradora = new Producto() { Nombre = "Refrigeradora", Marca = "GE" };
            Producto Microondas = new Producto() { Nombre = "Microondas", Marca = "Electrolux" };
            Producto Cocina = new Producto() { Nombre = "Cocina", Marca = "Mave" };

            //lista de clientes 
            Cliente Marco = new Cliente() 
            { 
                Nombres = "Marco Taco",
                Apellidos = "Taco Betancourt",
                ClienteId = 1,
                Correo = "eduardo@gmail.com",
                Direccion = "Conocoto",
                Telefono = 0983121592 
            };
            //lista de roles de pago 
            RoldePagos Cliente01 = new RoldePagos()
            {
                RolPagoId = 1,
                Cliente = "Marco Taco",
                AporteIEES = 40,
                Cargo = "Bodeguero",
                Horas_extra = 4,
                Sueldo = 425,
                Total = 380,
                Clientes = new List<Cliente>()
            };

            Repositorio db = new Repositorio();
           
        }
    }
}
