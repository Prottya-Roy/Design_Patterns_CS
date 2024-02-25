using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge_Pattern
{
    public class AttackBehaviour : IBehaviourOnInteraction
    {
        public void Interact()
        {
            Console.WriteLine("Attacting the Player...");
        }
    }
}
