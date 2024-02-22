using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    internal class Ecosystem
    {
        private readonly IHerbivore _herbivore;
        private readonly ICarnivore _carnivore;
        public Ecosystem(IAnimalEcoSystemFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }
        public void RunFoodChain()
        {
            _herbivore.Graze();
            _carnivore.Hunt();
        }
    }
}
