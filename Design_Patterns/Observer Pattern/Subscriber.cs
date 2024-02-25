using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer_Pattern
{
    public class Subscriber : ISubscriber
    {
        public string SubscriberName { get; private set; }
        public Subscriber(string name)
        {
            SubscriberName = name;
        }
        public void Notify(Article article)
        {
            Console.WriteLine($"{SubscriberName} received a new article! Title: {article.Title} - Topic: {article.Topic}");
        }
    }
}
