using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    internal class VeganMealBuilder : AMealBuilder
    {
        public override void SetAppetizer()
        {
            meal.Appetizer = "Hummas and Air Fried Chips";
        }
        public override void SetDrink()
        {
            meal.Drink = "Water";
        }
        public override void SetMainDish()
        {
            meal.MainDish = "Vegan Burger";
        }
        public override void SetSide()
        {
            meal.Side = "Salad";
        }
        public override void SetDessert()
        {
            meal.Dessert = "Fruit Bowl";
        }
    }
}
