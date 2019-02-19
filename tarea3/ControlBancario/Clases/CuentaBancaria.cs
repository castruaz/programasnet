namespace ControlBancario.Clases
{
    public class CuentaBancaria
    {
        private double saldo;

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
        
        public bool Retira(double cantidad) {
            if( saldo>= cantidad ) {
                saldo -= cantidad;
                return true;
            } 
            else return false;
        }

    }
}