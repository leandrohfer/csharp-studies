using ExercicioFixacao_MetodosAbstratos.Entitites;
using System.Globalization;

namespace ExercicioFixacao_MetodosAbstratos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char answer = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (answer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthSpendings = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new Individual(name, anualIncome, healthSpendings));
                }
                else if (answer == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, anualIncome, numberEmployees));
                }

                Console.WriteLine();
            }

            Console.WriteLine("TAXES PAID: ");

            double sum = 0;
            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += taxPayer.Tax();
            }

            Console.WriteLine($"\nTOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}