using System;
using System.Collections.Generic;
using System.Globalization;

namespace TopicosEspeciaisEmCSharp
{
    internal class OperacoesComTimeSpan
    {
        static void Teste(string[] args)
        {
            /*
             * Atributos que existem no objeto TimeSpan
             * 
             * Max e MinValue retornam, respectivamente, o maior e o menor valor 
             * possível de ser armazenado em um objeto TimeSpan
             */
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            /*
             * Zero retorna um TimeSpan zerado.
             */
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine("\nMaxValue: " + t1);
            Console.WriteLine("MinValue: " + t2);
            Console.WriteLine("Zero: " + t3);


            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            /*
             * Formas de retornar Atributos específicos do objeto TimeSpan
             */
            Console.WriteLine(t);
            Console.WriteLine("\nDias: " + t.Days);
            Console.WriteLine("Horas: " + t.Hours);
            Console.WriteLine("Minutos: " + t.Minutes);
            Console.WriteLine("Milissegundos: " + t.Milliseconds);
            Console.WriteLine("Segundos: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays (dias exatos, com fração): " + t.TotalDays);
            Console.WriteLine("TotalHours (horas exatas, com fração): " + t.TotalHours);
            Console.WriteLine("TotalMinutes (minutos exatos, com fração): " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds (segundos exatos, com fração): " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds (milissegundos exatos, com fração): " + t.TotalMilliseconds);


            /*
             * Operações de Adição, Subtração, Multiplicação e Divisão com o objeto TimeSpan
             */
            TimeSpan t4 = new TimeSpan(1, 30, 10);
            TimeSpan t5 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t4.Add(t5);
            TimeSpan dif = t4.Subtract(t5);
            TimeSpan mult = t5.Multiply(2.0);
            TimeSpan div = t5.Divide(2.0);

            Console.WriteLine("\n"+t4);
            Console.WriteLine(t5);

            Console.WriteLine("\nSoma entre os dois timespan: " + sum);
            Console.WriteLine("Subtração entre os dois timespan: " + dif);
            Console.WriteLine("Multiplicação do segundo timespan por 2: " + mult);
            Console.WriteLine("Divisão do segundo timespan por 2: " + div);  
        }
    }
}
