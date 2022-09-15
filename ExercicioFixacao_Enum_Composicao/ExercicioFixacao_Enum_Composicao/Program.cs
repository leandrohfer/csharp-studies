using System;
using System.Globalization;
using ExercicioFixacao_Enum_Composicao.Entities;
using ExercicioFixacao_Enum_Composicao.Entities.Enums;

namespace ExercicioFixacao_Enum_Composicao
{
    class Program
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("\nEnter client data: ");


            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());


            Client client = new Client(name, email, birthDate);


            Console.WriteLine("\nEnter order data: ");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());


            Order order = new Order(client, DateTime.Now, status);


            Console.Write("\nHow many items to this order? ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantify: ");
                int quantify = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantify, product);

                order.AddItem(orderItem);
            }


            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}