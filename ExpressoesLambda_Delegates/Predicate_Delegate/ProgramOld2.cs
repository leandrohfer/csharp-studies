using ExpressoesLambda_Delegates_LINQ.Predicate_Delegate.Entities;
using System.Security.Cryptography.X509Certificates;

namespace ExpressoesLambda_Delegates_LINQ.Predicate_Delegate
{
    internal class ProgramOld2
    {
        private static void Teste2(string[] args)
        {
            List<ProductOld> list = new List<ProductOld>();

            list.Add(new ProductOld("Tv", 900.00));
            list.Add(new ProductOld("Mouse", 50.00));
            list.Add(new ProductOld("Tablet", 350.50));
            list.Add(new ProductOld("HD Case", 80.90));

            /*
             * O Predicate é um Delegate, isto é, uma referência
             * para uma função
             * 
             * A função removeAll exige um predicate, portanto,
             * qualquer função que obedecer a forma do predicate
             * será aceita, seja ela declarada ou anonima (lambda)
             */
            Predicate<ProductOld> pr = p => p.Price >= 100.00 ;
            //Predicate<ProductOld> pr = ProductTest;

            //list.RemoveAll(pr);
            //list.RemoveAll(ProductTest);
            list.RemoveAll(p => p.Price >= 100.00);

            foreach (ProductOld product in list)
            {
                Console.WriteLine(product);
            }
        }

        /*
         * Função que recebe um objeto do tipo T e retorna um 
         * valor booleano
         */
        public static bool ProductTest (ProductOld p)
        {
            return p.Price >= 100.00;
        }
    }
}
