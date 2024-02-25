using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy_Pattern
{
    public class BusTravelStrategy : ITravelStrategy
    {
        public void GotoDestination()
        {
            Console.WriteLine("Traveler going to the destination by Bus at 15tk per km");
        }
    }
}
