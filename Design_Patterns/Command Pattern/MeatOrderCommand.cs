using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Command_Pattern
{
    public class MeatOrderCommand : IOrderCommand
    {
        private Kitchen kitchen;

        public MeatOrderCommand(Kitchen kitchen)
        {
            this.kitchen = kitchen;
        }
        public void Execute()
        {
            kitchen.PrepareMeat();
        }
    }
}
