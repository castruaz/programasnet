using System;

namespace ControlBancario.Clases
{
    [Serializable]
    public class CuentaDeCheques : CuentaBancaria
    {
        private double sobregiro;

        public CuentaDeCheques(double saldo, double sobregiro) : base(saldo) {
            this.sobregiro = sobregiro;
        }
        
        public override bool Retira(double cantidad) {  // override permite sobrecagar el metodo original
            if( cantidad >  saldo ) {
                double requiere = cantidad - saldo;
                if(sobregiro < requiere) {
                    return false;
                } else {
                    saldo = 0.0;
                    sobregiro -= requiere;
                }
            }  
            else {
                saldo -= cantidad;
                return true;
            }
            return true;
        }

    }
}