using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator_Pattern
{
    public class VegPizzaDecorator : APizzaDecorator
    {
        public VegPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + AddVegetable();
        }
        private string AddVegetable()
        {
            return ", Vegetable added";
        }
    }
}
