using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Pattern
{
    public abstract class AMealBuilder
    {
        protected Meal meal = new Meal();
        public abstract void SetDrink();
        public abstract void SetAppetizer();
        public abstract void SetMainDish();
        public abstract void SetSide();
        public abstract void SetDessert();
        public Meal GetMeal() => meal;
    }
}
