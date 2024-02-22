using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    internal class MealBuilder
    {
        public void PrepareMeal ( AMealBuilder builder )
        {
            builder.SetDrink();
            builder.SetAppetizer();
            builder.SetMainDish();
            builder.SetSide();
            builder.SetDessert();
        }
    }
}
