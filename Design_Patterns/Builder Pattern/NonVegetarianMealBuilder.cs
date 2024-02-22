using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    internal class NonVegetarianMealBuilder : AMealBuilder
    {
        public override void SetAppetizer()
        {
            meal.Appetizer = "Scotch Egg";
        }

        public override void SetDessert()
        {
            meal.Dessert = "Waffles & Ice Cream";
        }

        public override void SetDrink()
        {
            meal.Drink = "Martini";
        }

        public override void SetMainDish()
        {
            meal.MainDish = "Porterhouse Steak";
        }

        public override void SetSide()
        {
            meal.Side = "Bacon Wrapped Cheese Balls & Mashed Potatoes";
        }
    }
}
