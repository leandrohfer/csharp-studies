using ExpressoesLambda_Delegates_LINQ.Action_Delegate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoesLambda_Delegates_LINQ.Action_Delegate
{
    internal class ProgramOld3
    {
        private static void Main(string[] args)
        {
            /*
             * O delegate action pertence ao namespace System, ele
             * representa um método void que zero ou mais argumentos
             */
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*
             * As chaves servem para indicar que essa função lambda é
             * uma ação e não irá retornar nada
             */
            Action<Product> act = p => { p.Price += p.Price * 0.1; };
            //Action<Product> act = UpdatePrice;


            //list.ForEach(UpdatePrice);
            //list.ForEach(act);
            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void UpdatePrice (Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
