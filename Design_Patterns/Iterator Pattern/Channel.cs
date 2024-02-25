using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator_Pattern
{
    public class Channel
    {
        public double Frequency { get; private set; }
        public string Name { get; private set; }
        public Channel(double frequency, string name)
        {
            Frequency = frequency;
            Name = name;
        }
    }
}
