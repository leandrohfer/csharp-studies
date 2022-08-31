using System;
using System.Collections.Generic;
using System.Globalization;

namespace TopicosEspeciaisEmCSharp
{
    internal class OperacoesComDatetime
    {
        static void Teste(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            /*
             * Formas de retornar atributos específicos do objeto DateTime
             */
            Console.WriteLine(d);
            Console.WriteLine("\n1) Data: " + d.Date);
            Console.WriteLine("2) Dia: " + d.Day);
            Console.WriteLine("3) Dia da Semana: " + d.DayOfWeek);
            Console.WriteLine("4) Dia do Ano: " + d.DayOfYear);
            Console.WriteLine("5) Hora: " + d.Hour);
            Console.WriteLine("6) Tipo de horário: " + d.Kind);
            Console.WriteLine("7) Milissegundo: " + d.Millisecond);
            Console.WriteLine("8) Minuto: " + d.Minute);
            Console.WriteLine("9) Mês: " + d.Month);
            Console.WriteLine("10) Segundo: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Ano: " + d.Year);
            

            DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58);

            /*
             * Formas de formatar a saída do datetime como string.
             */
            string s1 = d1.ToLongDateString();
            string s2 = d1.ToLongTimeString();
            string s3 = d1.ToShortDateString();
            string s4 = d1.ToShortTimeString();
            string s5 = d1.ToString();
            string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d1.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine("\nToLongDateString(): " + s1);
            Console.WriteLine("ToLongTimeString(): " + s2);
            Console.WriteLine("ToShortDateString(): " + s3);
            Console.WriteLine("ToShortTimeString(): " + s4);
            Console.WriteLine("ToString(): " + s5);
            Console.WriteLine("ToString('yyyy-MM-dd HH:mm:ss'): " + s6);
            Console.WriteLine("ToString('yyyy-MM-dd HH:mm:ss.fff'): " + s7);


            /*
             * Operações de Adição e Subtração com o objeto DateTime
             * 
             * Dado um DateTime x = ...
             * 
             * 
             * Temos como operações de adição:
             * 
             * DateTime y = x.Add(timeSpan);
             * DateTime y = x.AddDays(double);
             * DateTime y = x.AddHours(double);
             * DateTime y = x.AddMilliseconds(double);
             * DateTime y = x.AddMinutes(double);
             * DateTime y = x.AddMonths(int);
             * DateTime y = x.AddSeconds(double);
             * DateTime y = x.AddTicks(long);
             * DateTime y = x.AddYears(int);
             * 
             * 
             * E como operações de subtração:
             * 
             * DateTime y = x.Subtract(timeSpan);
             * TimeSpan t = x.Subtract(dateTime);
             * 
             */
        }
    }
}
