using System;

namespace programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // Variable para numeros aleatorios

            // Declarar 3 vectores con 15 elementos vacios
            int[] A = new int[15];
            int[] B = new int[15];
            int[] C = new int[15];
             
            // Generar números aleatorios y rellenar los vectores A y B
            for(int i=0; i<A.Length; i++) A[i] = rnd.Next(1,30);
            for(int i=0; i<B.Length; i++) B[i] = rnd.Next(1,30);

            // Sumar vecto A y B y poner el resultado en C
            for(int i=0; i<A.Length; i++) 
                C[i] = A[i] + B[i];

            // Imprimir los vectores A , B, C
            Console.WriteLine("\nEl vector A"); Imprime(A);
            Console.WriteLine("\nEl vector B"); Imprime(B);
            Console.WriteLine("\nEl vector C"); Imprime(C);
        }

        static void Imprime(int[] v)
        {
            for(int i=0; i<v.Length; i++) 
               Console.Write($"{v[i]} ");
        }
    }
}
