using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    public class StateMain
    {
        public static void Main(string[] args)
        {
            Order order = new Order();
            order.PrintStatus();  
            order.NextState();
            order.PrintStatus();  
            order.NextState();
            order.PrintStatus();  
            order.PrevState();
            order.PrintStatus(); 
            order.SetState(new Canceled());
            order.PrintStatus();  
            Console.ReadKey();
        }
    }
}
