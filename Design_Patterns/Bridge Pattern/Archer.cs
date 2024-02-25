using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge_Pattern
{
    public class Archer : ACharacter
    {
        public Archer(IBehaviourOnInteraction behaviour) : base(behaviour) { }
        public override void Move()
        {
            Console.WriteLine("Archer Moving");
        }
    }
}
