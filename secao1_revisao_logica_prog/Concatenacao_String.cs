using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class SaidaConsole
    {
        static void Teste2(string[] args)
        {
            string nome = "Leandro Henrique";
            double saldo = 3505.54;
            int idade = 21;

            /*
             * Placeholder
             */
            Console.WriteLine("PlaceHolder");
            Console.WriteLine("{0} tem {1} anos e seu salário é {2}",
                nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("{0} tem {1} anos e seu salário é {2:F1}",
                nome, idade, saldo);
            Console.WriteLine("=================================");

            /*
             * Interpolação
             */
            Console.WriteLine("Interpolação:");
            Console.WriteLine($"{nome} tem {idade} anos e seu salário é {saldo:F1} reais");
            Console.WriteLine("=================================");

            /*
             * Concatenação
             */
            Console.WriteLine("Concatenação:");
            Console.WriteLine(nome + " tem " + idade + " anos e seu salário é " 
                + saldo.ToString("F1",CultureInfo.InvariantCulture) + " reais");
        }
    }
}
