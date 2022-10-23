using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.ExercicioFixacao_LINQ.Entities
{
    internal class Object
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Object(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
