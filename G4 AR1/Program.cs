using System;

namespace G4_AR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Resultado Test de capacitación";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            int totalPreguntas, preguntasContestas;
            double r3n, r3d;
            const int porcentaje=100;

            Console.WriteLine("Ingrese el número total de preguntas : ");
            totalPreguntas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número total de preguntas contestadas correctamente : ");
            preguntasContestas = int.Parse(Console.ReadLine());

            // Niveles
            // Máximo:                Porcentaje >= 90%
            // Medio:                 Porcentaje >= 75% y <90%
            // Regular:               Porcentaje >= 50% y <75%
            // Fuera de nivel:        Porcentaje >= 50% y <50%

            r3n = preguntasContestas * porcentaje;
            r3d = r3n / totalPreguntas;

            if (r3d >= 90)
            {
                Console.WriteLine("Su nivel es: Máximo, con un " + r3d + "% de acierto.");
            }
            else
            {
                if (r3d >= 75)
                {
                    Console.WriteLine("Su nivel es: Medio, con un " + r3d + "% de acierto.");
                }
                else
                {
                    if (r3d >= 50)
                    {
                        Console.WriteLine("Su nivel es: Regular, con un " + r3d + "% de acierto.");
                    }
                    else
                    {
                        if (r3d <50)
                        {
                            Console.WriteLine("Su nivel es: Fuera de nivel, con un " + r3d + "% de acierto.");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
