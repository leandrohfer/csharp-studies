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
        private static void Teste3(string[] args)
        {
            /*
             * O delegate action pertence ao namespace System, ele
             * representa um método void que zero ou mais argumentos
             */
            List<ProductOld3> list = new List<ProductOld3>();

            list.Add(new ProductOld3("Tv", 900.00));
            list.Add(new ProductOld3("Mouse", 50.00));
            list.Add(new ProductOld3("Tablet", 350.50));
            list.Add(new ProductOld3("HD Case", 80.90));

            /*
             * As chaves servem para indicar que essa função lambda é
             * uma ação e não irá retornar nada
             */
            Action<ProductOld3> act = p => { p.Price += p.Price * 0.1; };
            //Action<Product> act = UpdatePrice;


            //list.ForEach(UpdatePrice);
            //list.ForEach(act);
            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (ProductOld3 item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void UpdatePrice (ProductOld3 p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
