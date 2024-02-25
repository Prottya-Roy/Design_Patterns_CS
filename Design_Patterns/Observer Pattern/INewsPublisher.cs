using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer_Pattern
{
    public interface INewsPublisher
    {
        void AddSubscriber(string topic, ISubscriber subscriber);
        void RemoveSubscriber(string topic, ISubscriber subscriber);
        void Publish(Article article);
    }
}
