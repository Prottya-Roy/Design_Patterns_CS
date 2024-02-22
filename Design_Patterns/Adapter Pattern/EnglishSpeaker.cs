using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter_Pattern
{
    internal class EnglishSpeaker : IEnglishSpeaker
    {
        public string AskQuestion(string Words)
        {
            Console.WriteLine("Question Asked by [English Speaker and Can understand only English] : " + Words);
            ITranslator translator = new Translator();
            string replyFromFrenchSpeaker = translator.TranslateAndTellToOtherPerson(Words, "French");
            return replyFromFrenchSpeaker;
        }

        public string AnswerFortheQuestion(string Words)
        {
            string reply = null;
            if (Words.Equals("where are you?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "I am in USA";
            }
            return reply;
        }
    }
}
