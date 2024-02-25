using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator_Pattern
{
    public class RadioStation
    {
        private List<Channel> _channels = new List<Channel>();

        public void AddChannel(Channel channel)
        {
            _channels.Add(channel);
        }

        public IIterator<Channel> GetIterator()
        {
            return new RadioIterator(_channels);
        }
    }
}
