using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Command_Pattern
{
    public class CommandMain
    {
        public static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();

            IOrderCommand fishOrder = new FishOrderCommand(kitchen);
            IOrderCommand meatOrder = new MeatOrderCommand(kitchen);
            IOrderCommand burgerOrder = new BurgerOrderCommand(kitchen);
            IOrderCommand pastaOrder = new PastaOrderCommand(kitchen);

            Waiter waiter = new Waiter();

            waiter.TakeOrder(fishOrder);
            waiter.TakeOrder(meatOrder);
            waiter.TakeOrder(burgerOrder);
            waiter.TakeOrder(pastaOrder);

            waiter.CompleteOrder();
            Console.ReadLine();
        }
    }
}
