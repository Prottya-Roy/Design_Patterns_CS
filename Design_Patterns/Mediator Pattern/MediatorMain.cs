using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Mediator_Pattern
{
    public class MediatorMain
    {
        public static void Main(string[] args)
        {
            IControlTower controlTower = new ControlTower();
            
            controlTower.RegisterRunway(new Runway("R1"));
            var airplane1 = new Airplane("FL123", controlTower);
            var airplane2 = new Airplane("FL456", controlTower);
            airplane1.RequestLanding();
            airplane2.RequestLanding();
            
            Console.ReadKey();
        }
    }
}
