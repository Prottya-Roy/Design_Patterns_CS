using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Mediator_Pattern
{
    public class Runway
    {
        public string Id { get; }
        public Runway(string id)
        {
            Id = id;
        }
    }
}
