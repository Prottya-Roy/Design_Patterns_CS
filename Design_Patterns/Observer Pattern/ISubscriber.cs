using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer_Pattern
{
    public interface ISubscriber
    {
        public void Notify(Article article);
    }
}
