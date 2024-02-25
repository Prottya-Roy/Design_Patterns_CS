using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Composite_Pattern
{
    public class FileItem : AFileSystemItem
    {
        public long FileSize { get; set; }
        public FileItem(string name, long fileSize) : base(name)
        {
            this.FileSize = fileSize;
        }
        public override decimal GetSize()
        {
            return decimal.Divide(this.FileSize, 1024);
        }
    }
}
