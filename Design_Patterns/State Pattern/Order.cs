using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    public class Order
    {
        private IOrderState _currentState;
        public Order()
        {
            _currentState = new New();
        }
        public void SetState(IOrderState state)
        {
            _currentState = state;
        }
        public void NextState()
        {
            _currentState.Next(this);
        }
        public void PrevState()
        {
            _currentState.Prev(this);
        }
        public void PrintStatus()
        {
            _currentState.PrintStatus();
        }
    }
}
