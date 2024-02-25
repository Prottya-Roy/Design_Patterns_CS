using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer_Pattern
{
    public class ObserverMain
    {
        public static void Main(string[] args)
        {
            NewsPublisher newsPublisher = new NewsPublisher();

            Subscriber Prottya = new Subscriber("Prottya");
            Subscriber Nafees = new Subscriber("Nafees");
            Subscriber Emran = new Subscriber("Emran");
            Subscriber Adib = new Subscriber("Adib");

            newsPublisher.AddSubscriber("Tech", Nafees);
            newsPublisher.AddSubscriber("Tech", Emran);
            newsPublisher.AddSubscriber("Crypto", Adib);
            newsPublisher.AddSubscriber("Anime", Prottya);

            newsPublisher.Publish(new Article {Title="IPhone introduces new features" , Topic="Tech"});
            newsPublisher.Publish(new Article { Title = "Haikyu Movie break 2 Billion yen mark over one weekend", Topic = "Anime" });
            newsPublisher.Publish(new Article { Title = "BTC Surges and crosses 50k again", Topic = "Crypto" });
        }
    }
}
