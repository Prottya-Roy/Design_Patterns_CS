using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy_Pattern
{
    public class AutoTravelStrategy : ITravelStrategy
    {
        public void GotoDestination()
        {
            Console.WriteLine("Traveler going to the destination by Auto at 60tk per km");
        }
    }
}
