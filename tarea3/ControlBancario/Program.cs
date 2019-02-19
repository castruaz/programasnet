using System;
using ControlBancario.Clases;

namespace ControlBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos instacia de la clase y posteriormente resarvamos espacios en memoria
            CuentaBancaria micuenta;
            micuenta = new CuentaBancaria();
            micuenta.Saldo = 100;
            micuenta.Deposita(50);

            // Crear la clase y al mimso tiempo reservar espacio en memoria
            CuentaBancaria miotracuenta = new CuentaBancaria(300);
            // miotracuenta.Saldo = 300;
            miotracuenta.Deposita(10);

            Cliente micliente = new Cliente("Juan Perez Diaz");
            micliente.Cuenta = micuenta;

            Cliente miotrocliente = new Cliente("Maria Lopez Perez");
            miotrocliente.Cuenta = miotracuenta;

            Cliente clientazo = new Cliente("El chido one");
            clientazo.Cuenta = new CuentaBancaria(10000);

            if(miotracuenta.Retira(200)) 
                Console.WriteLine("Retiro Exitoso");
            else
                Console.WriteLine("No tienes saldo suficiente para el retiro");
            
            Console.WriteLine($"Saldo de mi cuenta 1 {micuenta.Saldo} ");
            Console.WriteLine($"Saldo de mi cuenta 2 {miotracuenta.Saldo} ");

            // Imprimir datos del cliente y saldo de sus cuentas
            Console.WriteLine($"{micliente.Nombre}, {micliente.Cuenta.Saldo}");
            Console.WriteLine($"{miotrocliente.Nombre}, {miotrocliente.Cuenta.Saldo}");
            Console.WriteLine($"{clientazo.Nombre}, {clientazo.Cuenta.Saldo}");

            Console.WriteLine("Hello World!");
        }
    }
}
