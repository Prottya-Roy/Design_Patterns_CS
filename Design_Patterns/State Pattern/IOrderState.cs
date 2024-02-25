using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State_Pattern
{
    public interface IOrderState
    {
        void Next(Order order);
        void Prev(Order order);
        void PrintStatus();
    }
}
