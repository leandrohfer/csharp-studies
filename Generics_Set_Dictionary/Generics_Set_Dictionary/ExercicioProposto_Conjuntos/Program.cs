using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Set_Dictionary.ExercicioProposto_Conjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            /*
             * ===============Course A ========================
             */
            Console.Write("How many students for course A? ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Student Code #{i+1}: ");
                int code = int.Parse(Console.ReadLine());

                set.Add(code);
            }
            Console.WriteLine();

            /*
             * ===============Course B ========================
             */
            Console.Write("How many students for course B? ");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Student Code #{i + 1}: ");
                int code = int.Parse(Console.ReadLine());

                set.Add(code);
            }
            Console.WriteLine();

            /*
             * ===============Course C ========================
             */
            Console.Write("How many students for course C? ");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Student Code #{i + 1}: ");
                int code = int.Parse(Console.ReadLine());

                set.Add(code);
            }
            Console.WriteLine();

            Console.WriteLine("Total students: " + set.Count);
        }
    }
}
