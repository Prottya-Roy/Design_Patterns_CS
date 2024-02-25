using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    public class Canceled : IOrderState
    {
        public void Next(Order order)
        {
            Console.WriteLine("Order is canceled and cannot proceed.");
        }
        public void Prev(Order order)
        {
            Console.WriteLine("Order is canceled and cannot go back.");
        }
        public void PrintStatus()
        {
            Console.WriteLine("Order is CANCELED.");
        }
    }
}
