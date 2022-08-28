using System;
using System.Globalization;

namespace Orientacao_a_Objetos
{
    class Conta {
        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        
        public Conta (int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta (int numero, string nome, double saldo) : this(numero, nome)
        {
            DepositarValor(saldo);
        }   

        public void DepositarValor(double valor)
        {
            Saldo += valor;
        }

        public void SacarValor(double valor)
        {
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
        static void Teste(string[] args)
        {
            Conta conta;

            Console.WriteLine("### CRIAÇÃO DE NOVA CONTA BANCÁRIA ###");
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome e sobrenome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá dépósito inicial (s/n)? ");
            string resp = Console.ReadLine();


            while (resp != "s" && resp != "n")
            {
                Console.WriteLine("\nVocê digitou uma resposta inválida, tente novamente!");

                Console.Write("Haverá dépósito inicial (s/n)? ");
                resp = Console.ReadLine();
            }


            if (resp == "s")
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(numero, nome, depositoInicial);
            }
            else 
            {
                conta = new Conta(numero, nome);
            }

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre com um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.DepositarValor(valor);

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre com um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.SacarValor(valor);

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
