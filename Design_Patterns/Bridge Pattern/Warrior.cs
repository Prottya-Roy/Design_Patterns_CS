using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge_Pattern
{
    public class Warrior : ACharacter
    {
        public Warrior(IBehaviourOnInteraction behaviour) : base(behaviour) { }
        public override void Move()
        {
            Console.WriteLine("Warrior Moving");
        }
    }
}
