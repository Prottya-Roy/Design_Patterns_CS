using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Command_Pattern
{
    public class FishOrderCommand : IOrderCommand
    {
        private Kitchen kitchen;

        public FishOrderCommand(Kitchen kitchen)
        {
            this.kitchen = kitchen;
        }
        public void Execute()
        {
            kitchen.PrepareFish();
        }
    }
}
