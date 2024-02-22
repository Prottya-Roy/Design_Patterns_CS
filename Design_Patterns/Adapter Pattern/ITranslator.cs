using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter_Pattern
{
    internal interface ITranslator
    {
        string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage);
    }
}
