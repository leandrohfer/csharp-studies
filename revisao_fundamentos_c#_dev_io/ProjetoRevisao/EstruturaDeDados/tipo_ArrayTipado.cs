using System;
using System.Collections;
internal class tipo_ArrayTipado
{
    private static void Teste(string[] args)
    {
        var arrayTipado = new int[3] {1, 2, 3};

        arrayTipado[2] = 10;

        Array.Resize(ref arrayTipado, 5);

        arrayTipado[4] = 100;

        foreach (var item in arrayTipado)
        {
            System.Console.WriteLine(item);
        }
    }
}