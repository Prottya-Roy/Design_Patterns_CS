using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Command_Pattern
{
    public class Waiter 
    {
        private List<IOrderCommand> orders = new List<IOrderCommand>();

        public void TakeOrder(IOrderCommand order)
        {
            orders.Add(order);
        }

        public void CompleteOrder()
        {
            foreach (IOrderCommand order in orders)
            {
                order.Execute();
            }
            orders.Clear();
        }
    }
}
