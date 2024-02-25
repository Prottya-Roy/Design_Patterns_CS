using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator_Pattern
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
        bool HasPrevious();
        T Previous();
    }
}
