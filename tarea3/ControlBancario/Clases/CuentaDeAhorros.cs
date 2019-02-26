using System;

namespace ControlBancario.Clases
{
   [Serializable]
    public class CuentaDeAhorros : CuentaBancaria  // Hereda de la clase CuentaBancaria
    {
        private double tasa;
        public CuentaDeAhorros(double saldo, double tasa) 
            : base(saldo) // Invocamos constructor de la clase base
        {
            this.tasa = tasa;
        }
        
    }
}