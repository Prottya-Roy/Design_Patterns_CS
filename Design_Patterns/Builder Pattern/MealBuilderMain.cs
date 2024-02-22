using Design_Patterns.Abstract_Factory_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    public class MealBuilderMain
    {
        public static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();
            Console.WriteLine("Which Meal Do you want (NonVeg/Vegan): ");
            string meal = Console.ReadLine();

            switch (meal.ToLower())
            {
                case "nonveg":
                    AMealBuilder nonVegMealBuilder = new NonVegetarianMealBuilder();
                    mealBuilder.PrepareMeal(nonVegMealBuilder);
                    Meal nonVegMeal = nonVegMealBuilder.GetMeal();
                    Console.WriteLine("Non Vegetarian Meal :");
                    nonVegMeal.ShowMeal();
                    break;

                case "vegan":
                    AMealBuilder vegMealBuilder = new VeganMealBuilder();
                    mealBuilder.PrepareMeal(vegMealBuilder);
                    Meal veganMeal = vegMealBuilder.GetMeal();
                    Console.WriteLine("Non Vegetarian Meal :");
                    veganMeal.ShowMeal();
                    break;

                default:
                    throw new ArgumentException("Invalid meal name");
            }
        }
    }
}
