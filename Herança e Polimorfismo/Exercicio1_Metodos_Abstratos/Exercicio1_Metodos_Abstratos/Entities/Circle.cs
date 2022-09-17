using System;
using System.Collections.Generic;
using Exercicio1_Metodos_Abstratos.Entities.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Metodos_Abstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
