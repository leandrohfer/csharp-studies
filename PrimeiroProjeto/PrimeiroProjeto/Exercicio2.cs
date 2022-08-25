using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Exercicio2
    {
        static void Teste6(String[] args)
        {
            Console.Write("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa? ");
            int numeroQuartos = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.Write("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] v = Console.ReadLine().Split(' ');
            string ultimoNome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2]);

            Console.WriteLine($"\n{nome}\n{numeroQuartos}\n{precoProduto:F2}\n{ultimoNome}\n{idade}\n{altura:F2}");
        }
    }
}
