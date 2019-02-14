using System;

namespace programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();  
            int[] A = new int[30];
            int pos, neg, cer, spos, sneg, scer;
            pos=neg=cer=spos=sneg=scer=0;
                        
            for(int i=0; i<A.Length; i++) A[i] = rnd.Next(-10,20);
            Console.WriteLine("\nEl vector A"); Imprime(A);

            for(int i=0; i<A.Length; i++) 
                if(A[i]==0) {
                    cer++;
                    scer+=A[i];
                }
                else if(A[i]>0) {
                        pos++;
                        spos+=A[i];
                }
                else {
                    neg++;
                    sneg+=A[i];
                }

            Console.WriteLine($"\nNumeros positivos {pos} y suman {spos}");
            Console.WriteLine($"\nNumeros negativos {neg} y suman {sneg}");
            Console.WriteLine($"\nNumeros cero      {cer} y suman {scer}");           }

        static void Imprime(int[] v)
        {
            for(int i=0; i<v.Length; i++) 
               Console.Write($"{v[i]} ");
        }
    }
}
