using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Template_Pattern
{
    public class TemplateMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Converting to PDF:");
            ADocumentConverter pdfConverter = new PdfConverter();
            pdfConverter.ConvertDocument("source.docx");
            Console.WriteLine("\nConverting to TXT:");
            ADocumentConverter txtConverter = new TxtConverter();
            txtConverter.ConvertDocument("source.docx");
            Console.ReadKey();
        }
    }
}
