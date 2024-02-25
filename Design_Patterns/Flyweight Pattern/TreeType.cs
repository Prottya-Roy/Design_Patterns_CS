﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight_Pattern
{
    public class TreeType
    {
        public string Name { get; }
        public string Color { get; }
        public string Texture { get; }
        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }
        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawn a {Name} tree with {Color} color and {Texture} texture at ({x}, {y})");
        }
    }
}
