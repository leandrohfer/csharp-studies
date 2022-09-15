using System;
using System.Collections.Generic;

namespace ExercicioFixacao_Enum_Composicao.Entities
{
    internal class OrderItem
    {
        public int Quantify { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }
        public OrderItem (int quantify, Product product)
        {
            Quantify = quantify;
            Product = product;
            Price = product.Price;
        }

        public double SubTotal()
        {
            return Price * Quantify;
        }

        public override string ToString()
        {
            return ($"{this.Product.Name}, ${Price:F2}, Quantify: {Quantify}, Subtotal: ${SubTotal():F2}");
        }
    }
}
