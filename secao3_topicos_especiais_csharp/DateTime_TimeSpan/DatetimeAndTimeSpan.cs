using System;
using System.Collections.Generic;
using System.Globalization;

namespace TopicosEspeciaisEmCSharp
{
    internal class DatetimeAndTimeSpan
    {
        static void Teste(string[] args)
        {
            /*
             * O DateTime representa um instante.
             * 
             * DateTime.now retorna o exato instante da execução do código.
             */
            DateTime now = DateTime.Now;

            Console.WriteLine("\n" + now);
            Console.WriteLine("Ticks: " + now.Ticks);

            /*
             * Exemplos de Construtores para Datetime
             * 
             * Data
             */
            DateTime d1 = new DateTime(2000, 8, 15);

            /* 
             * Data e Hora
             */
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);

            /* 
             * Data, Hora e Milissegundo
             */
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

            Console.WriteLine("\n" + d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            /*
             * Exemplos de Métodos (Builders) para Datetime
             * 
             * Data e Hora do instante em que se executa este builder.
             */
            DateTime d4 = DateTime.Now;

            /* 
             * O mesmo que o .Now, porém no padrão Universal de hora. 
             */
            DateTime d5 = DateTime.UtcNow;

            /* 
             * Retorna o dia atual com as horas zeradas.
             */
            DateTime d6 = DateTime.Today;
            Console.WriteLine("\n.Now: " + d4);
            Console.WriteLine(".UTCNow: " + d5);
            Console.WriteLine(".Today: " + d6);

            /*
             * Leitura de datas em string, o compilador entende formatos
             * comuns de data, como os abaixo.
             */
            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine("\nParse 2000-08-15: " + d7);
            Console.WriteLine("Parse 2000-08-15 13:05:58: " + d8);
            Console.WriteLine("Parse 15/08/2000: " + d9);
            Console.WriteLine("Parse 15/08/2000 13:05:58: " + d10);

            /*
             * Ou, é possível passar o formato que você desejar ao compilador, basta indicar
             * como você quer que ele leia a string utilizando "ParseExact()".
             */
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("\n" + d11);
            Console.WriteLine(d12 + "\n\n");



            // ############################################################################
            // ############################################################################


            /*
             * O TimeSpan, por sua vez, representa uma duração.
             * 
             * Abaixo temos um construtor de TimeSpan com hora, minuto e segundo.
             */
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            Console.WriteLine("\n" + t1);
            Console.WriteLine("Ticks: " + t1.Ticks);


            /*
             * Igualmente no Datetime, o TimeSpan também tem muitos construtores,
             * como os abaixo:
             * 
             * Instancia um TimeSpan com duração zerada.
             */
            TimeSpan t2 = new TimeSpan();
            Console.WriteLine("\nTimeSpan(): " + t2);

            /*
             * Instancia um TimeSpan com 900000000 de Ticks, o L no final serve para
             * indicar que o número é do tipo Long.
             */
            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine("TimeSpan(Ticks): " + t3);

            /*
             * Hora, minutos e segundos.
             */
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            Console.WriteLine("TimeSpan(hora, minuto, segundo): " + t4);

            /*
             * Dia, hora, minutos e segundos.
             */
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine("TimeSpan(dia, hora, minuto, segundo): " + t5);

            /*
             * Dia, hora, minutos, segundos e milissegundos.
             */
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine("TimeSpan(dia, hora, minuto, segundo, milissegundos): " + t6);

            
            /*
             * O método From() por sua vez possibilita a criação de um intervalo a partir
             * dos mais variados tipos de entradas.
             * 
             * O primeiro exemplo FromDays() cria um intervalo a partir de um parâmetro
             * que será lido em dias. Por exemplo o caso abaixo está criando um intervalo
             * que corresponde exatamente a um dia e meio.
             */
            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine("\nFromDays(1.5): " + t7);
            Console.WriteLine("FromHours(1.5): " + t8);
            Console.WriteLine("FromMinutes(1.5): " + t9);
            Console.WriteLine("FromSeconds(1.5): " + t10);
            Console.WriteLine("FromMilliseconds(1): " + t11);
            Console.WriteLine("FromTicks(900000000L): " + t12);
        }
    }
}
