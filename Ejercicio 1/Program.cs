using System;

namespace G6_E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Programa que imprime la tabla de multiplicar de un número");
            int nu;
            int num;
            int tab;
            Console.WriteLine("Ingrese el valor del número: ");
            nu = int.Parse(Console.ReadLine());
            Console.WriteLine("La tabla de : " + nu + " es ");
            Console.WriteLine("\n");
            Console.WriteLine("***********************************************");
            for (num = 1; num <= 10; num = num + 1 )
            {
                tab = nu * num;
                Console.WriteLine( nu + " x " + num + " = " + tab );
                Console.WriteLine("***********************************************");
            }

            Console.ReadKey();
        }
    }
}
