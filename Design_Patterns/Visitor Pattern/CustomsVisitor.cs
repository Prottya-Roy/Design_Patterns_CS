using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor_Pattern
{
    public class CustomsVisitor : IPackageVisitor
    {
        public void Visit(Letter letter)
        {
            Console.WriteLine("No customs instructions for letters.");
        }
        public void Visit(Parcel parcel)
        {
            Console.WriteLine("Regular customs check for parcels.");
        }
        public void Visit(InternationalPackage internationalPackage)
        {
            Console.WriteLine("Special customs instructions for international packages.");
        }
    }
}
