using System;
using ControlBancario.Clases;
using System.IO;

namespace ControlBancario
{
    class Program
    {
        static void MainV1(string[] args)
        {
            /* 
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
            */
        }

        static void Main(string[] args) {

            Banco mibanco = new Banco();
            
            string nomarch = "banco.bin";
            string actDir = Directory.GetCurrentDirectory();
            

            if(File.Exists(actDir+"/"+nomarch))
            {
                Console.WriteLine("Archivo de Datos Existe, los datos serán cargados del archivo ...");
                mibanco = new Banco();
                mibanco = Utilerias.Leer(nomarch);
            }
            else {
                Console.WriteLine("Archivo de Datos No Existe");
                mibanco = new Banco("Mac Pato Ricon S.A.");
                mibanco.AgregarCliente(new Cliente("Chente Fox"));
                mibanco.AgregarCliente(new Cliente("Felipe Beberon"));
                mibanco.AgregarCliente(new Cliente("Lord Peña"));
                mibanco.AgregarCliente(new Cliente("Cabecita Algodon"));

                mibanco.Clientes[0].AgregarCuenta(new CuentaDeCheques(100,2000));
                mibanco.Clientes[1].AgregarCuenta(new CuentaDeCheques(200,1000));
                mibanco.Clientes[1].AgregarCuenta(new CuentaDeAhorros(300,0.5));
                mibanco.Clientes[3].AgregarCuenta(new CuentaDeAhorros(1300,5000));
                mibanco.Clientes[3].AgregarCuenta(new CuentaDeCheques(2000,15000));

                mibanco.Clientes[0].Cuentas[0].Retira(300);
                mibanco.Clientes[1].Cuentas[1].Deposita(600);
                mibanco.Clientes[3].Cuentas[1].Retira(5000);
                Utilerias.Grabar(mibanco, "banco.bin");
            }

            Console.WriteLine("---- Reporte General del Banco --------------");
            Console.WriteLine($"{mibanco.Nombre}");

            foreach(Cliente cte in mibanco.Clientes) {
                Console.WriteLine($"Cliente: {cte.Nombre}");
                Console.WriteLine("Cuentas:");
                foreach(CuentaBancaria cta in cte.Cuentas) {
                    if(cta is CuentaDeAhorros) 
                        Console.WriteLine($"Ahorros: saldo {cta.Saldo} ");
                    else
                        Console.WriteLine($"Cheques: saldo {cta.Saldo} ");
                }
                Console.WriteLine();
            }
        }



        
    }
}
