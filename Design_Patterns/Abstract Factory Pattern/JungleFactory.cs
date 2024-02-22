using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    internal class JungleFactory : IAnimalEcoSystemFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Leopard();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Deer();
        }
    }
}
