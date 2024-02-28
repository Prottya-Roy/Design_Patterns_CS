using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor_Pattern
{
    public class VisitorMain
    {
        public static void Main(string[] args)
        {
            var packages = new IMailPackage[]
            {
            new Letter(),
            new Parcel(),
            new InternationalPackage()
            };
            var postageVisitor = new PostageVisitor();
            var customsVisitor = new CustomsVisitor();
            foreach (var package in packages)
            {
                package.Accept(postageVisitor);
                package.Accept(customsVisitor);
            }
            Console.WriteLine($"Total Postage Cost: {postageVisitor.TotalPostage}");
            Console.ReadKey();
        }
    }
}
