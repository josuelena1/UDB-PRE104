using System;

namespace G6_E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Number evaluation");
            Int32 number, numberdiv, x, y;
            int contador;
            Int32 sumn = 0;
            Int32 sump = 0;
            Int32 summ15 = 0;
            Int32 acu2 = 0;

            Console.WriteLine("Ingrese los valores de los 10 números");
            Console.WriteLine("\n");

            // Setting the FOR
            for (contador = 1; contador <= 10; contador = contador + 1)
            {
                Console.Write("Ingrese el valor número " + contador + " : ");
                number = Int32.Parse(Console.ReadLine());
                numberdiv = number / 15;
                //Setting the IF
                if (number < 0)
                {
                    sumn++;
                }
                else if (number > 0)
                {
                    sump++;
                }
                // Multiple of 2
                x = (number % 2);
                if (x == 0)
                {
                    acu2 = acu2 + number;

                }
                else
                {
                }
                // Multiple of 15
                y = (number % 15);
                if (y == 0)
                {
                    summ15++;
                }
                else
                {
                }
            }

            // Negative numbers
            Console.WriteLine("La cantidad de número negativos es : " + sumn);

            // Positive numbers
            Console.WriteLine("La cantidad de número positivos es : " + sump);

            // Multiple of 15
            Console.WriteLine("La cantidad de múltiplos de 15 es : " + summ15);

            // Accumulated of even numbers
            // Acumulado de números pares
            Console.WriteLine("El acumulado de los múltiplos de 2 es : " + acu2 );

            Console.ReadKey();
        }
    }
}
