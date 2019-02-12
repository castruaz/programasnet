using System;

namespace programa2
{
    class Program
    {
        static int Main(string[] args)
        {
            string  tamaño="", ingredientes="", cubierta="", para="";
            string[] ing;
            char tam, cub, com, par;

            if(args.Length<4) {
                Console.Clear();
                Console.WriteLine("Programa que permite al usuario comprar una pizza");
                Console.WriteLine("Debes especificar la opción desada\n");
                Console.WriteLine("<Tamaño> <Ingredientes> <Cubierta> <Para>");
                menu();
                return 1;
            }   

            // Tamaño
            tam =  char.Parse(args[0]);
            if(tam=='P') tamaño="Pequeña";
            else if(tam=='M') tamaño="Mediana";
            else if(tam=='G') tamaño="Grande";

            // Ingredientes
            ing = args[1].Split("+");
            foreach(string i in ing) {
                if(i=="EX") ingredientes+="Extra Queso ";
                else if(i=="CH") ingredientes+="Champiñones ";
                else if(i=="CL") ingredientes+="Clavos ";
                else if(i=="CE") ingredientes+="Cebolla ";
            }

            // Cubierta
            cub = char.Parse(args[2]);
            if(cub=='D') cubierta="Pequeña";
            else if(tam=='G') cubierta="Gruesa";

            // Para 
            par = char.Parse(args[3]);
            if(par=='C') para="Comer Aquí ";
            else if(par=='L') para="Llevar";

            // Al final queda así
            Console.WriteLine($"Tu pizza es de tamaño {tamaño} ");
            Console.WriteLine($"Contiene los siguientes ingredientes: {ingredientes} ");
            Console.WriteLine($"Es de cubierta {cubierta}");
            Console.WriteLine($"Es para {para}");

            return 0;
        }

        static void menu() {
            Console.WriteLine("Tamaño: (P)equeña, (M)ediana o (G)rande");
            Console.WriteLine("Ingredientes: (EX)tra Queso, (CH)ampiñones, (CL)avos, (CE)bolla");
            Console.WriteLine("Cubierta: (D)elgada, (G)ruesa");
            Console.WriteLine("Para: (C)omer Aqui, (L)levar");
        }
    }
}
