using System;
using System.Globalization;

namespace Orientacao_a_Objetos
{
    class Conta {
        public int Numero { get; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        
        public Conta ()
        {
            Console.WriteLine("### CRIAÇÃO DE NOVA CONTA BANCÁRIA ###");

            Console.Write("Digite o número da conta: ");
            Numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome e sobrenome do titular da conta: ");
            Nome = Console.ReadLine();

            Console.Write("Haverá dépósito inicial (s/n)? ");
            string answer = Console.ReadLine();

            while (answer != "s" && answer != "n")
            {
                Console.WriteLine("Você digitou uma resposta inválida, tente novamente!");

                Console.Write("Haverá dépósito inicial (s/n)? ");
                answer = Console.ReadLine();
            }

            if (answer == "s")
            {
                Console.Write("Digite o valor do depósito inicial: ");
                Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else if (answer == "n")
            {
                Saldo = 0.0;
            }
        }

        public void DepositarValor()
        {
            Console.Write("\nEntre com um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Saldo += valor;
        }

        public void SacarValor()
        {
            Console.Write("\nEntre com um valor para saque: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Saldo -= (valor + 5) ;
        }

        public override string ToString()
        {
            return 
                "Conta " + 
                Numero +
                ", Titular: " +
                Nome +
                ", Saldo: R$" +
                Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    internal class SegundoExercicioFixacao
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);

            conta.DepositarValor();

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta);

            conta.SacarValor();

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
