using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class CastingConversion
    {
        static void Main(String[] args)
        {
            double x;
            float y;

            x = 4.5;

            /*
             * Conversão explícita (Casting)
             */
            y = (float)x;

            int a1 = 5;
            int b1 = 2;

            double resultado = (double)a1 / b1;
            double resultado2 = 5.0 / b1;
            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2) - 4.0 * a * c;

            double baskara = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(baskara);
            Console.WriteLine(delta);

            /*
             * Conversão de String para inteiro, método int.parse()
             */
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(n2);
        }
    }
}
