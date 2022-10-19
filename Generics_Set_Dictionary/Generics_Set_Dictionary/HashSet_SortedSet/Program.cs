using System;
using System.Collections.Generic;

namespace Generics_Set_Dictionary.HashSet_SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string str in set)
            {
                Console.WriteLine(str);
            }
        }
    }
}
