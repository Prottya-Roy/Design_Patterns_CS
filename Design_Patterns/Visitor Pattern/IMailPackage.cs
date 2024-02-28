using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor_Pattern
{
    public interface IMailPackage
    {
        void Accept(IPackageVisitor packageVisitor);
    }
}
