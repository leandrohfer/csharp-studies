using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio1_Heranca_Polimorfismo.Entities;

namespace Exercicio1_Heranca_Polimorfismo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int number = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char answer = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (answer == 'y') {
                    Console.Write("Additional Charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, additional);

                    employees.Add(employee);
                } 
                else if (answer == 'n')
                {
                    Employee employee = new Employee(name, hours, valuePerHour);

                    employees.Add(employee);
                }

                Console.WriteLine();
            }

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - ${employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
