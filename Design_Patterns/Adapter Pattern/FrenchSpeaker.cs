using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter_Pattern
{
    internal class FrenchSpeaker : IFrenchSpeaker
    {
        public string AskQuestion(string Words)
        {
            Console.WriteLine("Question Asked by [French Speaker and Can understand only French] : " + Words);
            ITranslator translator= new Translator();
            string replyFromEnglishSpeaker = translator.TranslateAndTellToOtherPerson(Words, "English");
            return replyFromEnglishSpeaker;
        }
        public string AnswerFortheQuestion(string Words)
        {
            string reply = null;
            if (Words.Equals("comment allez-vous?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "Je suis très bien";
            }
            return reply;
        }
    }
}
