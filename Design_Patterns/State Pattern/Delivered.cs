using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    public class Delivered : IOrderState
    {
        public void Next(Order order)
        {
            Console.WriteLine("Order is already delivered.");
        }
        public void Prev(Order order)
        {
            order.SetState(new Shipped());
        }
        public void PrintStatus()
        {
            Console.WriteLine("Order is DELIVERED.");
        }
    }
}
