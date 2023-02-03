using ExercicioFixacao_Heranca_Polimorfismo.Entities;
using System.Globalization;

namespace ExercicioFixacao_Heranca_Polimorfismo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char answer = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (answer == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (answer == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufacturedDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufacturedDate));
                }
                else if (answer == 'c')
                {
                    products.Add(new Product(name, price));
                }

                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}