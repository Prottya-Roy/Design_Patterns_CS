using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor_Pattern
{
    public interface IPackageVisitor
    {
        void Visit(Letter letter);
        void Visit(Parcel parcel);
        void Visit(InternationalPackage internationalPackage);
    }
}
