using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator_Pattern
{
    public class DecoratorMain
    {
        public static void Main(string[] args)
        {
            PlainPizza plainPizzaObj = new PlainPizza();
            string plainPizza = plainPizzaObj.MakePizza();
            Console.WriteLine(plainPizza);

            VegPizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(plainPizzaObj);
            string vegPizza = vegPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + vegPizza + "' using VegPizzaDecorator");

            APizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizzaObj);
            string chickenPizza = chickenPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + chickenPizza + "' using ChickenPizzaDecorator");
        }
    }
}
