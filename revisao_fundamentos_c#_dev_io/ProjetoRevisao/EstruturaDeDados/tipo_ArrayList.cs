using System;
using System.Collections;
internal class tipo_ArrayList
{
    private static void Teste(string[] args)
    {
        var lista = new ArrayList();

        lista.Add(1);
        lista.Add("Leandro");
        lista.Add(true);

        Console.WriteLine(lista[2]);

        lista.RemoveAt(2);

        lista.Clear();
        
        foreach (var item in lista)
        {
            System.Console.WriteLine(item);
        }
    }
}