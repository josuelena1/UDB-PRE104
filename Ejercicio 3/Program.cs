using System;

namespace G6_E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Evaluación de triángulos");
            Int32 Lado1, Lado2, Lado3;
            int num, contador;
            int sumaeq = 0;
            int sumaes = 0;
            int sumais = 0;

            //Número de triángulos a ingresar
            Console.WriteLine("Ingrese la cantidad de triángulos a evaluar");
            num = int.Parse(Console.ReadLine());
            Console.Clear();

            //Estableciendo el FOR
            for (contador = 1; contador <= num; contador = contador + 1)
            {
                Console.Write("Digite el valor del Lado 1 del triángulo: ");
                Lado1 = Int32.Parse(Console.ReadLine());
                Console.Write("Digite el valor del Lado 2 del triángulo: ");
                Lado2 = Int32.Parse(Console.ReadLine());
                Console.Write("Digite el valor del Lado 3 del triángulo: ");
                Lado3 = Int32.Parse(Console.ReadLine());

                //Establecer el IF
                if (Lado1 == Lado2 && Lado2== Lado3)
                {
                    Console.WriteLine("El triángulo es equilatero");
                    sumaeq++;
                }
                else if (Lado1 != Lado2 && Lado1 != Lado3 && Lado2 != Lado3)
                {
                    Console.WriteLine("El triángulo es escaleno");
                    sumaes++;
                }
                else 
                {
                    Console.WriteLine("El triángulo es isósceles");
                    sumais++;
                }


            }
            Console.WriteLine("Ha ingresado: " + sumaeq + " triángulos de tipo equilatero.");
            Console.WriteLine("Ha ingresado: " + sumaes + " triángulos de tipo escaleno.");
            Console.WriteLine("Ha ingresado: " + sumais + " triángulos de tipo isóseles.");

            //Estableciendo el tipo de triángulo que posee menor cantidad
            if (sumaeq < sumaes || sumaeq < sumais)
            {
                Console.WriteLine("El tipo de triángulo equilatero es el que ha ingresado en menor cantidad");
            }
            else if (sumaes < sumaeq || sumaes < sumais)
            {
                Console.WriteLine("El tipo de triángulo escaleno es el que ha ingresado en menor cantidad");
            }
            else
            {
                Console.WriteLine("El tipo de triángulo isósceles es el que ha ingresado en menor cantidad");
            }

            Console.ReadKey();
        }
    }
}
