using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator_Pattern
{
    public class IteratorMain
    {
        public static void Main(string[] args)
        {
            RadioStation myStation = new RadioStation();
            myStation.AddChannel(new Channel(88.1, "Classic Rock"));
            myStation.AddChannel(new Channel(102.3, "Pop Hits"));
            myStation.AddChannel(new Channel(98.7, "News Channel"));

            IIterator<Channel> iterator = myStation.GetIterator();

            Console.WriteLine("Forward:");
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next().Name);
            }

            Console.WriteLine("Backward:");
            while (iterator.HasPrevious())
            {
                Console.WriteLine(iterator.Previous().Name);
            }

            Console.ReadKey();
        }
    }
}
