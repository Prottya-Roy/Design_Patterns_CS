using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge_Pattern
{
    public class TraderBehaviour : IBehaviourOnInteraction
    {
        public void Interact()
        {
            Console.WriteLine("Trading with the Player...");
        }
    }
}
