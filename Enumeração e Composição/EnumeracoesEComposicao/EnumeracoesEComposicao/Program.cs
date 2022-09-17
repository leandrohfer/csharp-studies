using EnumeracoesEComposicao.Entities;
using EnumeracoesEComposicao.Entities.Enums;
using System;

namespace EnumeracoesEComposicao
{
    class Program
    {
        static void Main(String[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);

            // FORMA DE CONVERTER UM TIPO ENUMERADO PARA STRING
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            // FORMA DE CONVERTER UMA STRING PARA UM TIPO ENUMERADO
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}