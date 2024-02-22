using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    public class Meal
    {
        public string Drink { get; set; }
        public string Appetizer { get; set; }
        public string MainDish { get; set; }
        public string Side { get; set; }
        public string Dessert { get; set; }
        public void ShowMeal()
        {
            Console.WriteLine($"Drink: {Drink}");
            Console.WriteLine($"Appetizer: {Appetizer}");
            Console.WriteLine($"Main Dish: {MainDish}");
            Console.WriteLine($"Side: {Side}");
            Console.WriteLine($"Dessert: {Dessert}");
        }
    }
}
