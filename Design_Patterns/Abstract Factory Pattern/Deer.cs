using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    internal class Deer : IHerbivore
    {
        public void Graze()
        {
            Console.WriteLine("Deer is grazing.");
        }
    }
}
