using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Enum_Composicao.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department() { }
        public Department(string name)
        {
            Name = name;
        }   
    }
}
