using Generics_Set_Dictionary.ExercicioFixacao_Conjuntos.Entities;
using System;
using System.Collections.Generic;

namespace Generics_Set_Dictionary.ExercicioFixacao_Conjuntos
{
    internal class ProgramOld5
    {
        static void Teste5(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

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

                        set.Add(name);
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
