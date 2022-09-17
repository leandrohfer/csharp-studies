using System;
using System.Collections.Generic;
using System.Text;
using ExercicioFixacao_Enum_Composicao.Entities.Enums;

namespace ExercicioFixacao_Enum_Composicao.Entities
{
    internal class Order
    {
        public Client Client { get; set; } = new Client();
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(Client client, DateTime moment, OrderStatus status)
        {
            Client = client;
            Moment = moment;
            Status = status;
        }

        public void AddItem (OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem (OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total ()
        {
            double sum = 0;
            foreach (OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append($"Client: {this.Client.Name} (");
            sb.Append(this.Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.AppendLine($") - {this.Client.Email}");
            sb.AppendLine("Order Items: ");

            foreach (OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine($"Total Price: ${Total():F2}");

            return sb.ToString();
        }
    }
}
