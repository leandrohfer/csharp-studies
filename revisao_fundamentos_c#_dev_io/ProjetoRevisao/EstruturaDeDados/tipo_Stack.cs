using System;
using System.Collections;
internal class tipo_Stack
{
    private static void Teste(string[] args)
    {
        var stack = new Stack<string>();

        stack.Push("Leandro");
        stack.Push("Henrique");
        stack.Push("Abestrino");

        var proximo = stack.Peek();

        var nome = stack.Pop();
        var nome2 = stack.Pop();

        System.Console.WriteLine(proximo);
        System.Console.WriteLine(nome);
        System.Console.WriteLine(nome2);

        foreach (var item in stack)
        {
            System.Console.WriteLine(item);
        }
    }
}