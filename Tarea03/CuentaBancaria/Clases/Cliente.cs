namespace CuentaBancaria.Clases
{
    public class Cliente
    {
         private string nombre;
         public Cliente(string nombre) {
             this.nombre = nombre;
         }
         public string Nombre
         {
             get { return nombre;}
             set { nombre = value;}
         }

        public Cuenta Micta { get => micta; set => micta = value; }

        private Cuenta micta;
          
        
         

        
    }
}