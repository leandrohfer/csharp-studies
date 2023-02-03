using System;

namespace Orientacao_a_Objetos
{
    internal class ExercicioFixacaoMatrizes
    {
        static void Main(String[] args)
        {
            Console.Write("Insira as dimensões da matriz: ");
            string[] dimensao = Console.ReadLine().Split(' ');

            int linha = int.Parse(dimensao[0]);
            int coluna = int.Parse(dimensao[1]);

            int[,] matriz = new int[ linha, coluna];

            Console.WriteLine("\nInsira os dados da matriz: ");
            for (int i = 0; i < linha; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');

                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = int.Parse(vect[j]);
                }
            }

            Console.Write("\nInsira um elemento para pesquisar: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (valor == matriz[i, j])
                    {
                        Console.WriteLine($"\nPosição: ({i}, {j})");

                        if (i != 0)
                        {
                            Console.WriteLine($"Elemento em cima: {matriz[i - 1, j]}");
                        }
                        if (i != linha - 1)
                        {
                            Console.WriteLine($"Elemento em baixo: {matriz[i + 1, j]}");
                        }
                        if (j != 0)
                        {
                            Console.WriteLine($"Elemento à esquerda: {matriz[i, j - 1]}");
                        }
                        if (j != coluna - 1)
                        {
                            Console.WriteLine($"Elemento à direita: {matriz[i, j + 1]}");
                        }
                    }
                }
            }
        }
    }
}
