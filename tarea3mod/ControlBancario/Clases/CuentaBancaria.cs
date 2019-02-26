using System;
namespace ControlBancario.Clases
{
    [Serializable] 
    public class CuentaBancaria
    {
        protected double saldo; // protected permite que las clases derivadas accedan

        public CuentaBancaria() {}
        public CuentaBancaria(double saldo) {
            this.saldo = saldo;
        }

        public double Saldo
        {
            get { return saldo;}
            set { saldo = value;}
        }
        
        public void Deposita(double cantidad) {
            if(cantidad>0) 
                saldo += cantidad;
        }
        
        public virtual bool Retira(double cantidad) {  // virtual permite sobrecagar el metodo
            if( saldo>= cantidad ) {
                saldo -= cantidad;
                return true;
            } 
            else return false;
        }

    }
}