using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre="";
            Console.Write("Dame tu nombre ");
            nombre = Console.ReadLine();

            Console.WriteLine($"Hello World! {nombre}");
            
        }
    }
}
