using System;
using System.Collections.Generic;

namespace TopicosEspeciaisEmCSharp
{
    internal class FuncoesParaString
    {
        static void Teste(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";
            Console.WriteLine("Original: #" + original + "#");
            /*
             * O método ToUpper() torna todos os caracteres da string em maiúsculos.
             */
            string s1 = original.ToUpper();
            Console.WriteLine("ToUpper: #" + s1 + "#");

            /*
             * O método ToLower() torna todos os caracteres da string em minúsculos.
             */
            string s2 = original.ToLower();
            Console.WriteLine("ToLower: #" + s2 + "#");

            /*
             * O método Trim() remove todos os espaços em branco antes ou depois do
             * conjunto de caracteres.
             */
            string s3 = original.Trim();
            Console.WriteLine("Trim: #" + s3 + "#");

            /*
             * Os métodos IndexOf() e LastIndexOf() retornam, respectivamente, o primeiro
             * e último índice do string em que existe o trecho do parâmetro.
             * 
             * Por exemplo, abaixo o método irá retornar o índice da string em que há a 
             * primeira ocorrência de "bc".
             */
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);

            /*
             * O método Substring() cria uma string recortada da original a partir de um 
             * índice ou a partir de um intervalo.
             * 
             * Os exemplos abaixo primeiro recortam a string inteira a partir do índice 3
             * e posteriormente recortam a string inteira a partir do índice 3 em um 
             * intervalo de 5 caracteres.
             */
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            Console.WriteLine("Substring(3): #" + s4 + "#");
            Console.WriteLine("Substring(3, 5): #" + s5 + "#");

            /*
             * O método Replace() substitui na string original, um caractere/string por
             * outro caractere/string.
             */
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            Console.WriteLine("Replace('a', 'x'): #" + s6 + "#");
            Console.WriteLine("Replace('abc', 'xy'): #" + s7 + "#");

            /*
             * Os métodos abaixo testam se a string dada como parâmetro é nula ou vazia
             * OU é nula ou contém espaços brancos.
             */
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
