using System;
using System.Globalization;

namespace Orientacao_a_Objetos
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Numero { get; set; }

    }
    internal class ExercicioFixacaoVetores
    {
        static void Main(String[] args)
        {
            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());

            Quarto[] vect = new Quarto[10];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nAluguel #" + (i+1) + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int numero = int.Parse(Console.ReadLine());

                vect[numero] = new Quarto { Nome = nome, Email = email, Numero = numero };
            }

            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{vect[i].Numero}: {vect[i].Nome}, {vect[i].Email}");
                }
            }
        }
    }
}
