using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio1_Metodos_Abstratos.Entities;
using Exercicio1_Metodos_Abstratos.Entities.Enums;

namespace Exercicio1_Metodos_Abstratos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int number = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char answer = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());


                if (answer == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(width, height, color));
                }
                else if (answer == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(radius, color));
                }

                Console.WriteLine();
            }

            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
