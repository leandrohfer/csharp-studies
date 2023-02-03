using System;
using System.Collections.Generic;

namespace Generics_Set_Dictionary.HashSet_SortedSet
{
    internal class ProgramOld4
    {
        static void teste4(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            /*
             * UnionWith (Unir com) = União de conjuntos
             */
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            /*
             * IntersectWith (Interseção com) = Interseção de conjuntos
             */
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            /*
             * ExceptWith (Diferença com) = Diferença entre conjuntos
             */
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            HashSet<string> set = new HashSet<string>();

            set.Add("tv");
            set.Add("notebook");
            set.Add("tablet");

            Console.WriteLine(set.Contains("notebook"));

            /*
             * O SortedSet sempre retorna ordenado 
             */
            PrintCollection(c);
            PrintCollection(d);
            PrintCollection(e);
        }

        /*
         * A interface IEnumerable é uma interface implementada por todas as coleções
         * (collections) básicas do pacote System.Collections. Basicamente é uma forma
         * genérica para as outras Collections
         */
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
