using System;
using System.Collections;
internal class tipo_Dictionary
{
    private static void Teste(string[] args)
    {
        var dicionario = new Dictionary<int, string>()
        {
            {10, "Dez testes"},
            {1, "Um teste"}
        };

        dicionario.Add(100, "Leandro");

        dicionario[50] = "Aprendendo";

        System.Console.WriteLine(dicionario[50]);

        foreach (var item in dicionario)
        {
            System.Console.WriteLine("Key: " + item.Key + " | Value: " + item.Value);
        }
    }
}