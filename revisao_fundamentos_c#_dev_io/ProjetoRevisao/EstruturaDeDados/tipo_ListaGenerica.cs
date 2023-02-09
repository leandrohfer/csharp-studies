using System;
using System.Collections;
internal class tipo_ListaGenerica
{
    private static void Teste(string[] args)
    {
        /*
        *  Tudo que for genérico em .NET necessita de < >, logo após a definição 
        *  do tipo de dado, define-se o tamanho da lista. A diferença deste tamanho
        *  pré-definido é que quando extrapolar o limite da lista, ela fará o resize 
        *  sozinha com transparência.
        */
        var lista = new List<string>(10) 
        {
            "Leandro"
        };

        lista.Add("Jorge");
        lista.Add("Letíma");

        lista.RemoveAt(2);

        foreach (var item in lista)
        {
            System.Console.WriteLine(item);
        }
    }
}