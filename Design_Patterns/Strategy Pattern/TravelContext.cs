using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy_Pattern
{
    public class TravelContext
    {
        private ITravelStrategy travelStrategy;

        public void SetTravelStrategy(ITravelStrategy strategy)
        {
            travelStrategy = strategy;
        }

        public void Go()
        {
            travelStrategy.GotoDestination();
        }
    }
}
