using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    public class Shipped : IOrderState
    {
        public void Next(Order order)
        {
            order.SetState(new Delivered());
        }
        public void Prev(Order order)
        {
            order.SetState(new Processed());
        }
        public void PrintStatus()
        {
            Console.WriteLine("Order is SHIPPED.");
        }
    }
}
