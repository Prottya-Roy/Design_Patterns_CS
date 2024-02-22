using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Prototype_Pattern
{
    public class Car : ICarPrototype
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public bool Sunroof { get; set; }

        public ICarPrototype Clone()
        {
            return (ICarPrototype)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Model} | Color: {Color} | Engine: {Engine} | Sunroof: {Sunroof}";
        }
    }
}
