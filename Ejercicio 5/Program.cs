using System;

namespace G6_E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Numbers from 1 to 30, except 25");
            Int32 number =1;
            int contador;

            Console.WriteLine("Números del 1 al 30, excepto el 25: ");
            Console.WriteLine("\n");

            for (contador = 1; contador <31; contador = contador+1)
            {
                number = contador;
                if (number <25 | number >25 && number <31)
                Console.WriteLine(number);
            }
            
            Console.ReadKey();
        }
    }
}
