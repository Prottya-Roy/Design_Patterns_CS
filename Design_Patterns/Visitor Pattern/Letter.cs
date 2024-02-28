using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor_Pattern
{
    public class Letter : IMailPackage
    {
        public double Weight { get; } = 0.1;
        public void Accept(IPackageVisitor packageVisitor)
        {
            packageVisitor.Visit(this);
        }
    }
}
