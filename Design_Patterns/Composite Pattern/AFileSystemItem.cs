using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Composite_Pattern
{
    public abstract class AFileSystemItem
    {
        public string Name { get; set; }
        public AFileSystemItem(string name)
        {
            this.Name = name;
        }

        public abstract decimal GetSize();
    }
}
