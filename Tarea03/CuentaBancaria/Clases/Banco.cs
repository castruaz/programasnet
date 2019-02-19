using System.Collections.Generic;

namespace CuentaBancaria.Clases
{
    public class Banco
    {
         private List<Cliente> clientes;

         public Banco() {
             clientes = new List<Cliente>();
         }
         public List<Cliente> Clientes
         {
             get { return clientes;}
             set { clientes = value;}
         }

         public void AgregarCliente(Cliente cliente) {
             clientes.Add(cliente);
         }
    }
}