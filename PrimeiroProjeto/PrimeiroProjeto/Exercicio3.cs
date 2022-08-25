using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Exercicio3
    {
        static void Teste7(String[] Args)
        {
            Console.WriteLine("###Exercício 1 e 2###");
            Console.Write("Insira um número: ");
            int numero = int.Parse(Console.ReadLine());

            if ((numero >= 0) && (numero % 2 == 0))
            {
                Console.WriteLine("\nNÃO NEGATIVO E PAR");
            } else if ((numero >= 0) && (numero % 2 == 1))
            {
                Console.WriteLine("\nNÃO NEGATIVO E ÍMPAR");
            } else if ((numero < 0) && (numero % 2 == 0))
            {
                Console.WriteLine("\nNEGATIVO E PAR");
            } else
            {
                Console.WriteLine("\nNEGATIVO E ÍMPAR");
            }

            Console.WriteLine("=====================");

            Console.WriteLine("\nA senha é 2002");
            Console.Write("Insira a senha: ");

            int senha = int.Parse(Console.ReadLine());
            while (senha != 2002)
            {
                Console.Write("Senha inválida, tente novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!");
        }
    }
}
