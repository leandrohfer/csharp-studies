using ExercicioFixacao_Interfaces.Entities;
using ExercicioFixacao_Interfaces.Services;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data: ");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Date (dd/MM/yyyy): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.Write("Contract Value: ");
        double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Contract contract = new Contract(number, date, totalValue);


        Console.Write("Enter number of installments: ");
        int numberInstallment = int.Parse(Console.ReadLine());

        PaymentInstallment paymentInstallment = new PaymentInstallment(numberInstallment, new PaymentPaypal());

        paymentInstallment.ProcessPayment(contract);

        Console.WriteLine("\nInstallments: ");
        foreach (Installment installment in contract.Installments)
        {
            Console.WriteLine(installment);
        }
    }
}