using System;

namespace programa6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[10];
            double[] B = new double[10];
            double[] C = new double[10];

            Console.WriteLine("Programa que lee dos vectores A y B y los multiplica");
            Console.WriteLine("\nDame los elementos del arreglo A[]");
            Leer(A);
            Console.WriteLine("\nDame los elementos del arreglo B[]");
            Leer(B);
            C = Multiplica(A,B);
            Console.WriteLine("\nResultados");
            Console.WriteLine("\nArreglo A[]");Imprime(A);
            Console.WriteLine("\nArreglo B[]");Imprime(B);
            Console.WriteLine("\nArreglo C[]");Imprime(C);
        }

        static void Imprime(double[] v) {
            for(int i=0; i<v.Length; i++)
                Console.Write($" {v[i]} ");
        }

        static void Leer(double[] v) {
            for(int i=0; i<v.Length; i++) {
                Console.Write($"Elemento {i+1} =");
                v[i] = double.Parse(Console.ReadLine());
            }
        }

        static double[] Multiplica(double[] a, double[] b) {
            double[] t = new double[a.Length];
            for(int i=0; i<a.Length; i++) {
                t[i] = a[i] * b[i];
            }
            return t;
        }

    }
}
