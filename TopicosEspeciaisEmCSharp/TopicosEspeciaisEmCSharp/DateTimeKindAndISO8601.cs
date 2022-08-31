using System;
using System.Collections.Generic;
using System.Globalization;

namespace TopicosEspeciaisEmCSharp
{
    internal class DateTimeKindAndISO8601
    {
        static void Main(string[] args)
        {
            /*
             * Instanciando objetos datetime definindo o tipo deles como Local, UTC ou indefined.
             */
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);


            Console.WriteLine("d1: " + d1);
            /*
             * Tipo do DateTime
             */
            Console.WriteLine("d1 Kind: " + d1.Kind);
            /*
             * Convertendo um DateTime para Horário Local
             */
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            /*
             * Convertendo um DateTime para Horário UTC
             */
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());


            /*
             * Padrão ISO 8601: yyyy-MM-ddTHH:mm:ssZ
             * 
             * o Z indica que a data/hora está em Utc
             */
            DateTime d4 = DateTime.Parse("2000-08-15 10:05:58");

            /*
             * Como o Z do padrão ISO 8601 indica que a data/hora está em UTC,
             * o compilador entende a data como em UTC porém instancia como local,
             * tanto o Kind deste DateTime quanto o próprio valor dele.
             * 
             * Por exemplo, a instanciação abaixo está salvando na variável d5 a data
             * 15/08/2000 10:05:58 com Kind Local. A data está noo padrão UTC mas ela
             * é instanciada com kind local.
             * 
             * Utilizando os padrões do computador/servidor que está sendo executado
             * o código.
             */
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("d4: " + d4);
            Console.WriteLine("d4 Kind: " + d4.Kind);
            Console.WriteLine("d4 to Local: " + d4.ToLocalTime());
            Console.WriteLine("d4 to Utc: " + d4.ToUniversalTime());
            Console.WriteLine();
            
            Console.WriteLine("d5: " + d5);
            Console.WriteLine("d5 Kind: " + d5.Kind);
            Console.WriteLine("d5 to Local: " + d5.ToLocalTime());
            Console.WriteLine("d5 to Utc: " + d5.ToUniversalTime());
            Console.WriteLine();

            /*
             * Exibindo a data no formato abaixo está errado, pois você não garante que
             * o respectivo DateTime está mesmo no horário Universal.
             */
            Console.WriteLine(d5.ToString("yyyy-MM-ddTHH:mm:ssZ"));

            /*
             * Portanto, esta é a forma correta de exibir um DateTime que recebeu um valor
             * no padrão ISO 8601. Primeiro convertemos o DateTime para Formato Universal
             * (UTC) e depois o formatamos com o ToString().
             */
            Console.WriteLine(d5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
