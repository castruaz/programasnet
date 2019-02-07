using System;

namespace PagaTrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int horas;
            float paga, tasa=0.1f;
            float pagabruta, impuesto, paganeta;

            // Console.Clear();
            Console.WriteLine("Programa que Calcula la paga de un Trabajador");

            // Entrada
            Console.Write("Nombre del trabajador  : "); nombre=Console.ReadLine();
            Console.Write("Horas Trabajadas       : "); horas=int.Parse(Console.ReadLine());
            Console.Write("Paga por hora          : "); paga=int.Parse(Console.ReadLine());

            // Proceso
            pagabruta = horas * paga;
            impuesto  = pagabruta * tasa;
            paganeta  = pagabruta - impuesto;

            // Salida
            Console.WriteLine($"El trbajador {nombre}");
            Console.WriteLine($"Trabajo {horas} horas, se le pago {paga} pesos por hora");
            Console.WriteLine($"Se tiene un impuesto de {impuesto} ");
            Console.WriteLine($"Se tiene una pagabruta de {pagabruta} ");
            Console.WriteLine($"Se tiene una paganeta de {paganeta} ");
        }
    }
}
