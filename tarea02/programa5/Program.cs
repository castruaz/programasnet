using System;

namespace programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // Variable para numeros aleatorios

            int[] A = new int[15];
            int[] B = new int[15];
            int tr = A.Length-1;
             
            for(int i=0; i<A.Length; i++) A[i] = rnd.Next(1,30);

            for(int i=tr; i>=0; i--) 
                B[tr-i] = A[i]; 

            // Imprimir los vectores A , B, C
            Console.WriteLine("\nEl vector A"); Imprime(A);
            Console.WriteLine("\nEl vector B"); Imprime(B);
        }

        static void Imprime(int[] v)
        {
            for(int i=0; i<v.Length; i++) 
               Console.Write($"{v[i]} ");
        }
    }
}
