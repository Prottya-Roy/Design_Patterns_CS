using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Mediator_Pattern
{
    public interface IControlTower
    {
        void RegisterRunway(Runway runway);
        bool RequestLandingPermission(Airplane airplane);
        void ReleaseRunway(Runway runway);
    }
}
