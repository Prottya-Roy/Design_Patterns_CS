using Design_Patterns.Builder_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Prototype_Pattern
{
    public class PrototypeMain
    {
        public static void Main(string[] args)
        {
            Car prototypeCar = new Car
            {
                Model = "Sedan",
                Color = "Blue",
                Engine = "V6",
                Sunroof = true
            };
            Console.WriteLine("Original Car Configuration:");
            Console.WriteLine(prototypeCar);
            // Now clone the prototype and make modifications for a new configuration
            Car clonedCar = (Car)prototypeCar.Clone();
           while(true)
            {
                Console.WriteLine("Which Part of The Clone car do you want to Change(model/color/engine/sunroof): ");
                string changePropertyName = Console.ReadLine();
                switch (changePropertyName.ToLower())
                {
                    case "model":
                        Console.WriteLine("New Model of the clone car: ");
                        string newModel = Console.ReadLine();
                        clonedCar.Model = newModel;
                        break;

                    case "color":
                        Console.WriteLine("New Color of the clone car: ");
                        string newColor = Console.ReadLine();
                        clonedCar.Color = newColor;
                        break;

                    case "engine":
                        Console.WriteLine("New Engine of the clone car: ");
                        string newEngine = Console.ReadLine();
                        clonedCar.Engine = newEngine;
                        break;

                    case "sunroof":
                        Console.WriteLine("do you want sunroof on the clone car(yes/no): ");
                        string sunroof = Console.ReadLine();
                        switch (sunroof.ToLower())
                        {
                            case "yes":
                                clonedCar.Sunroof = true;
                                break;
                            case "no":
                                clonedCar.Sunroof = false;
                                break;
                        }
                        break;

                    default:
                        throw new ArgumentException("Invalid Property name");
                }
                Console.WriteLine("\nCloned and Modified Car Configuration:");
                Console.WriteLine(clonedCar);
            }
        }
    }
}
