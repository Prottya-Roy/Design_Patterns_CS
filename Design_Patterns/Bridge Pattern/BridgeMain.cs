using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge_Pattern
{

    public class BridgeMain
    {
        public static void Main(string[] args)
        {
            ACharacter _warrior = new Warrior(new AttackBehaviour());
            ACharacter _archer = new Archer(new AttackBehaviour());
            ACharacter _merchant = new Merchant(new TraderBehaviour());

            _warrior.Move();
            _warrior.Interact();

            _archer.Move();
            _archer.Interact();

            _merchant.Move();
            _merchant.Interact();
        }
    }
}
