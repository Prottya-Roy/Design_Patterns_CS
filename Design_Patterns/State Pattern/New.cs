using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    public class New : IOrderState
    {
        public void Next(Order order)
        {
            order.SetState(new Processed());
        }
        public void Prev(Order order)
        {
            Console.WriteLine("The order is in its new state.");
        }
        public void PrintStatus()
        {
            Console.WriteLine("Order is in NEW state.");
        }
    }
}
