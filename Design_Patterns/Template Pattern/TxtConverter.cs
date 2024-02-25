using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Template_Pattern
{
    public class TxtConverter : ADocumentConverter
    {
        protected override void ParseContent()
        {
            Console.WriteLine("Parsing content for TXT conversion.");
        }
        protected override void ConvertToTargetFormat()
        {
            Console.WriteLine("Converting content to plain text format.");
        }
        protected override void SaveConvertedDocument()
        {
            Console.WriteLine("Saving document as TXT.");
        }
    }
}
