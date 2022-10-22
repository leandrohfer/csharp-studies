using ExpressoesLambda_Delegates_LINQ.Predicate_Delegate.Entities;
using System.Security.Cryptography.X509Certificates;

namespace ExpressoesLambda_Delegates_LINQ.Predicate_Delegate
{
    internal class ProgramOld2
    {
        private static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*
             * O Predicate é um Delegate, isto é, uma referência
             * para uma função
             * 
             * A função removeAll exige um predicate, portanto,
             * qualquer função que obedecer a forma do predicate
             * será aceita, seja ela declarada ou anonima (lambda)
             */
            list.RemoveAll(ProductTest);
            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        /*
         * Função que recebe um objeto do tipo T e retorna um 
         * valor booleano
         */
        public static bool ProductTest (Product p)
        {
            return p.Price >= 100.00;
        }
    }
}
