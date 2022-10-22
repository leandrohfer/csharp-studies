using ExpressoesLambda_Delegates_LINQ.Action_Delegate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoesLambda_Delegates_LINQ.Action_Delegate
{
    internal class ProgramOld4
    {
        private static void Main(string[] args)
        {
            /*
             * O delegate Func igual ao delegate Action recebe zero ou
             * mais argumentos, porém, a diferença reside no fato de que 
             * ele deve retornar algum valor
             */
            List<ProductOld4> list = new List<ProductOld4>();

            list.Add(new ProductOld4("Tv", 900.00));
            list.Add(new ProductOld4("Mouse", 50.00));
            list.Add(new ProductOld4("Tablet", 350.50));
            list.Add(new ProductOld4("HD Case", 80.90));

            //Func<ProductOld4, string> func = NameUpper;
            Func<ProductOld4, string> func = p => p.Name.ToUpper();

            //List<string> result = list.Select(func).ToList();
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        static string NameUpper(ProductOld4 product)
        {
            return product.Name.ToUpper();
        }
    }
}
