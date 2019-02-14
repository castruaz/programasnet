using System;

namespace programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = {10,20,30,40,50,60,70,80,90,100,10,20,30,40,50,60,70,80,90,100,10,20,30,40,50,60,70,80,90,100,10,20,30,40,50,60,70,80,90,100};
            int suma=0, c=0;
            float promedio;

            Console.Clear();

            // Calcular promedio
            for(int i=0; i<vector.Length; i++)  
                suma+=vector[i];
            
            promedio = suma / vector.Length;

            Console.WriteLine($"El promedio es {promedio}");

            // Verificar elementos mayores que el promedio y contarlos
            for(int i=0; i<vector.Length; i++)
                if(vector[i]>promedio) {
                    Console.Write($"{vector[i]} ");
                    c++;
                }
            
            Console.WriteLine($"\nElementos mayores que el promedio {c}");

        }
    }
}
