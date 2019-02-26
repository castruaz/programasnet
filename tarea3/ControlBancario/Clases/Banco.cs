
using System.Collections.Generic;
using System;

namespace ControlBancario.Clases
{
    [Serializable]
    public class Banco
    {
        private string nombre;
        private List<Cliente> clientes;

       public Banco() {
           
       } 
        public Banco(string nombre) {
            this.nombre = nombre;
            clientes = new List<Cliente>();
        }
        public string Nombre
        {
            get { return nombre;}
        }
        
        public void AgregarCliente(Cliente cte) {
            clientes.Add(cte);
        }

        public List<Cliente> Clientes {
            get { return clientes; }
        }

    }
}