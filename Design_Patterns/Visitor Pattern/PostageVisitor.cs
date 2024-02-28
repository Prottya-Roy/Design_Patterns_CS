using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor_Pattern
{
    public class PostageVisitor : IPackageVisitor
    {
        public double TotalPostage { get; private set; } = 0;
        public void Visit(Letter letter)
        {
            TotalPostage += letter.Weight * 0.5;
        }
        public void Visit(Parcel parcel)
        {
            TotalPostage += parcel.Weight * 2; 
        }
        public void Visit(InternationalPackage internationalPackage)
        {
            TotalPostage += internationalPackage.Weight * 5;
        }
    }
}
