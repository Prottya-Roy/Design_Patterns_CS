using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    public class Processed : IOrderState
    {
        public void Next(Order order)
        {
            order.SetState(new Shipped());
        }
        public void Prev(Order order)
        {
            order.SetState(new New());
        }
        public void PrintStatus()
        {
            Console.WriteLine("Order is PROCESSED.");
        }

    }
}
