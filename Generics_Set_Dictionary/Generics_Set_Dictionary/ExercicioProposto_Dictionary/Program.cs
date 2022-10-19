using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Set_Dictionary.ExercicioProposto_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> candidates = new Dictionary<string, int>();

            HashSet<string> set = new HashSet<string>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        if (candidates.ContainsKey(name))
                        {
                            candidates[name] += votes;
                        }
                        else
                        {
                            candidates.Add(name, votes);
                        }
                    }
                    foreach (KeyValuePair<string, int> candidate in candidates)
                    {
                        Console.WriteLine(candidate.Key + ": " + candidate.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
