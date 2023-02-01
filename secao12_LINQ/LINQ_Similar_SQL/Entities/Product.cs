using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQ_Lambda.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category CategoryId { get; set; }

        public override string ToString()
        {
            return Id + 
                ", " + 
                Name + 
                ", " + 
                Price.ToString("F2", CultureInfo.InvariantCulture) + 
                ", " +
                CategoryId.Name +
                ", " +
                CategoryId.Tier;
        }
    }
}
