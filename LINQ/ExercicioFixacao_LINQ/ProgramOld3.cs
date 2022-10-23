using LINQ.ExercicioFixacao_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object = LINQ.ExercicioFixacao_LINQ.Entities.Object;

namespace LINQ.ExercicioFixacao_LINQ
{
    internal class ProgramOld3
    {
        static void Teste(String[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Object> list = new List<Object>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Object(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
