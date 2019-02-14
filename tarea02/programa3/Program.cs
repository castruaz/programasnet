using System;

namespace programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // Variable para numeros aleatorios

            // Declarar 1 vectores con 20 elementos vacios
            double[] A = new double[20];
            double[] C = new double[20];  

            // Generar números aleatorios y rellenar el vector
            for(int i=0; i<A.Length; i++) A[i] = rnd.Next(1,10);
            

            // Sumar vecto A y B y poner el resultado en C
            for(int i=0; i<A.Length; i++) 
                C[i] = Math.Pow(A[i],3); 

            // Imprimir los vectores A , B, C
            Console.WriteLine("\nEl vector A"); Imprime(A);
            Console.WriteLine("\nEl vector C"); Imprime(C);
        }

        static void Imprime(double[] v)
        {
            for(int i=0; i<v.Length; i++) 
               Console.Write($"{v[i]} ");
        }
    }
}
