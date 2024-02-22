using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator_Pattern
{
    public abstract class APizzaDecorator : IPizza
    {
        protected IPizza pizza;

        public APizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual string MakePizza()
        {
            return pizza.MakePizza();
        }
    }
}
