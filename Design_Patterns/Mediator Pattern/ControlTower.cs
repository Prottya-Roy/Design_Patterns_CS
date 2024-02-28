using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Mediator_Pattern
{
    public class ControlTower : IControlTower
    {
        private List<Runway> _availableRunways = new List<Runway>();
        public void RegisterRunway(Runway runway)
        {
            _availableRunways.Add(runway);
        }
        public bool RequestLandingPermission(Airplane airplane)
        {
            if (_availableRunways.Any())
            {
                var assignedRunway = _availableRunways.First();
                _availableRunways.Remove(assignedRunway);
                airplane.AssignRunway(assignedRunway);
                return true;
            }
            return false;
        }
        public void ReleaseRunway(Runway runway)
        {
            _availableRunways.Add(runway);
        }
    }
}
