using LINQ.ExercicioProposto_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.ExercicioProposto_LINQ
{
    internal class Program
    {
        static void Teste5(String[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double salaryValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nEmail of people whose salary is more than {salaryValue.ToString("F2")}:");

            var emails = list.Where(p => p.Salary >= salaryValue).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (var item in emails)
            {
                Console.WriteLine(item);
            }

            double value = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.Write($"\nSum of salary of people whose name starts with 'M': {value}");
        }
    }
}
