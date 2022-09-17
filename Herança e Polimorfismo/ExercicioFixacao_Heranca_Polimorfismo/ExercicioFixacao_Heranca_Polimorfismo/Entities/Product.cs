using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao_Heranca_Polimorfismo.Entities
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

        public virtual string PriceTag()
        {
            string answer = $"{Name} ${Price.ToString("F2", CultureInfo.InvariantCulture)}";

            return answer;
        }
    }
}
