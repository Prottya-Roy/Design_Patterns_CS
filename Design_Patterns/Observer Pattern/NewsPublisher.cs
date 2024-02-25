using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer_Pattern
{
    public class NewsPublisher : INewsPublisher
    {
        private Dictionary<string, List<ISubscriber>> topicSubscribers = new Dictionary<string, List<ISubscriber>>();
        public void AddSubscriber(string topic, ISubscriber subscriber)
        {
            if (!topicSubscribers.ContainsKey(topic))
            {
                topicSubscribers[topic] = new List<ISubscriber>();
            }
            topicSubscribers[topic].Add(subscriber);
        }
        public void RemoveSubscriber(string topic, ISubscriber subscriber)
        {
            if (topicSubscribers.ContainsKey(topic))
            {
                topicSubscribers[topic].Remove(subscriber);
            }
        }
        public void Publish(Article article)
        {
            if (topicSubscribers.ContainsKey(article.Topic))
            {
                foreach (var subscriber in topicSubscribers[article.Topic])
                {
                    subscriber.Notify(article);
                }
            }
        }
    }
}
