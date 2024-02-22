using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    internal class Lion : ICarnivore
    {
        public void Hunt()
        {
            Console.WriteLine("Lion is Hunting");
        }
    }
}
