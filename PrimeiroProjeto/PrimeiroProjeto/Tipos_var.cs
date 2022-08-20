// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace Primeiro
{
    class Tipos_var
    {
        static void MainAntigo(string[] args)
        {
            char teste = 'F';

            /**
             * Variáveis do tipo char podem receber o
             * caractere diretamente ou por meio de
             * códigos unicodes com o prefixo "\u".
             */ 
            char letra = '\u0042';

            float n1 = 4.5f;
            double n2 = 4.554682;

            int n3 = 4500;
            long n4 = 4500L;

            /*
             * O tipo String é um tipo de dado especial,
             * ele é uma cadeia de caracteres Unicode
             * imutável!
             * 
             * Ao "alterar" o valor de um dado tipo string
             * na verdade se está criando um novo string.
             */
            string nome = "Leandro Henrique";

            /*
             * O tipo Objetct por sua vez é um tipo genérico
             * de dado, isto é, ele aceita todos os outros
             * tipos.
             * 
             * Toda classe em C# é subclasse de Object
             */
            object nome2 = "Leonardo Augusto";
            object numerofloat = 4.9f;

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.WriteLine(teste);
            Console.WriteLine(letra);

            /*
             * Formatando a saída de um Double para 3 casas
             * decimais.
             */
            Console.WriteLine(n2.ToString("F3"));

            /*
             * O método CultureInfo do namespace system.globalization invalida
             * as pré configurações de país do computador e colocar ponto no 
             * lugar da vírgula na hora de exibir o valor da variável no console.
             */
            Console.WriteLine(n2.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
