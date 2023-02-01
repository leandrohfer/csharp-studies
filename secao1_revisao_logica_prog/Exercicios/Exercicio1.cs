using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Exercicio1
    {
        static void Teste5(String[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R$ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2:F2}");

            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero {genero}\n");

            Console.WriteLine($"Medidas com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arrendodado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
