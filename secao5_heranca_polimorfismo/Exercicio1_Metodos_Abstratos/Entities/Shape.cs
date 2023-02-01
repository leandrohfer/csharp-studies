﻿using System;
using System.Collections.Generic;
using Exercicio1_Metodos_Abstratos.Entities.Enums;

namespace Exercicio1_Metodos_Abstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
