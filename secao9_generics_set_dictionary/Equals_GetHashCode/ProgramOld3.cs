﻿using Generics_Set_Dictionary.Equals_GetHashCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Set_Dictionary.Equals_GetHashCode
{
    internal class ProgramOld3
    {
        static void Teste3(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
