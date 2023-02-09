using System;
using System.Collections;
internal class tipo_Queue
{
    private static void Teste(string[] args)
    {
        var queue = new Queue<string>();

        queue.Enqueue("Leandro");
        queue.Enqueue("Henrique");
        queue.Enqueue("Abestrino");

        var proximo = queue.Peek();

        var nome = queue.Dequeue();
        var nome2 = queue.Dequeue();

        System.Console.WriteLine(proximo);
        System.Console.WriteLine(nome);
        System.Console.WriteLine(nome2);

        foreach (var item in queue)
        {
            System.Console.WriteLine(item);
        }
    }
}