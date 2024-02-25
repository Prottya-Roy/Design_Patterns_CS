using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Composite_Pattern
{
    public class Directory : AFileSystemItem
    {

        private List<AFileSystemItem> Childrens = new List<AFileSystemItem>();

        public Directory(string name) : base(name)
        {
        }

        public void AddComponent(AFileSystemItem NewNode)
        {
            this.Childrens.Add(NewNode);
        }
        public void RemoveComponent(AFileSystemItem RemoveNode)
        {
            this.Childrens.Remove(RemoveNode);
        }
        public override decimal GetSize()
        {
            return this.Childrens.Sum(x => x.GetSize());
        }
    }
}
