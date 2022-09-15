using System;

namespace ExercicioFixacao_Enum_Composicao.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
