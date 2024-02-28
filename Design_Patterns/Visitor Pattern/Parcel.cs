using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor_Pattern
{
    public class Parcel : IMailPackage
    {
        public double Weight { get; } = 1.5;
        public void Accept(IPackageVisitor packageVisitor)
        {
            packageVisitor.Visit(this);
        }
    }
}
