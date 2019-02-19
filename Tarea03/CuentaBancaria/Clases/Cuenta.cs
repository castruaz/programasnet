namespace CuentaBancaria.Clases
{
    public class Cuenta
    {
        private double saldo;

        public Cuenta(double saldo) {
            this.saldo = saldo;
        }

        public double Saldo
        {
            get { return saldo;}
            set { saldo = value;}
        }
        
        public void Deposita(double cantidad)
        {
            saldo += cantidad;
        }
        public bool Retira(double cantidad)
        {
            if (saldo >= cantidad)
            {
                saldo -= cantidad;
                return true;
            }
            else return false;
        }
    }
}