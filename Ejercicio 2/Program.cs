using System;

namespace G6_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Puntos en un plano cartesiano");

            //setting variables
            Double x, y;
            int contador = 0;
            int cantpares;

            
            Console.Write("Ingrese la cantidad de pares a procesar : ");
            cantpares = int.Parse(Console.ReadLine());


            for (contador = 1; contador <= cantpares; contador = contador + 1)
            {
                Console.Write("Coordenada 'x' : ");
                x = Double.Parse(Console.ReadLine());
                Console.Write("Coordenada 'y' : ");
                y = Double.Parse(Console.ReadLine());

                if (x > 0 & y > 0)
                {
                    Console.WriteLine("Los puntos se ubican en el cuadrante 1.");
                }
                else if (x < 0 & y > 0)
                {
                    Console.WriteLine("Los puntos se ubican en el cuadrante 2.");
                }
                else if (x < 0 & y < 0)
                {
                    Console.WriteLine("Los puntos se ubican en el cuadrante 3.");
                }
                else if (x > 0 & y < 0)
                {
                    Console.WriteLine("Los puntos se ubican en el cuadrante 4.");
                }
            }

          
            Console.ReadKey();
        }
    }
}
