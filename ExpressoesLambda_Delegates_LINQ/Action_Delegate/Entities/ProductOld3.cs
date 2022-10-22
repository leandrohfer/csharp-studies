using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExpressoesLambda_Delegates_LINQ.Action_Delegate.Entities
{
    internal class ProductOld3
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductOld3 (string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
