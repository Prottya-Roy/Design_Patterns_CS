using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge_Pattern
{
    public abstract class ACharacter
    {
        protected IBehaviourOnInteraction? _interactionBehaviour;

        public ACharacter(IBehaviourOnInteraction behaviour)
        {
            _interactionBehaviour = behaviour;
        }
        public abstract void Move();
        public virtual void Interact()
        {
            if(_interactionBehaviour != null)
            {
                _interactionBehaviour.Interact();
            }
        }

    }
}
