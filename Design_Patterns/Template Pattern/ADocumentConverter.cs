using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Template_Pattern
{
    public abstract class ADocumentConverter
    {
        public void ConvertDocument(string filePath)
        {
            LoadDocument(filePath);
            ParseContent();
            ConvertToTargetFormat();
            SaveConvertedDocument();
        }
        private void LoadDocument(string filePath)
        {
            Console.WriteLine($"Loading document from {filePath}.");
        }
        protected abstract void ParseContent();
        protected abstract void ConvertToTargetFormat();
        protected abstract void SaveConvertedDocument();
    }
}
