using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Template_Pattern
{
    public class PdfConverter : ADocumentConverter
    {
        protected override void ParseContent()
        {
            Console.WriteLine("Parsing content for PDF conversion.");
        }
        protected override void ConvertToTargetFormat()
        {
            Console.WriteLine("Converting content to PDF format.");
        }
        protected override void SaveConvertedDocument()
        {
            Console.WriteLine("Saving document as PDF.");
        }
    }
}
