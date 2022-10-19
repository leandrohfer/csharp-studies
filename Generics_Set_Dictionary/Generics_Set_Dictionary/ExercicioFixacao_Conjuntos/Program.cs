using Generics_Set_Dictionary.ExercicioFixacao_Conjuntos.Entities;
using System;
using System.Collections.Generic;

namespace Generics_Set_Dictionary.ExercicioFixacao_Conjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string[] line;
                    string name;
                    DateTime instant;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine().Split(' ');
                        name = line[0];
                        instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecord { Username = name, Instant = instant });
                    }

                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
