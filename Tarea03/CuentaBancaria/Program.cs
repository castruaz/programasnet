using System;
using CuentaBancaria.Clases;

namespace CuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
             Banco miBanco = new Banco();
             

             miBanco.AgregarCliente(new Cliente("Juan Camaney"));
             miBanco.AgregarCliente(new Cliente("Carlos Castaneda"));
             miBanco.AgregarCliente(new Cliente("Juan Perez Lopez"));

             miBanco.Clientes[0].Micta= new Cuenta(100);


             foreach(Cliente cte in miBanco.Clientes) {
                 Console.WriteLine($"Cliente {cte.Nombre}");
                if(cte.Micta!=null)
                    Console.WriteLine($"{cte.Micta.Saldo}");
                else
                    Console.WriteLine("Nell");
             }

        }
    }
}
