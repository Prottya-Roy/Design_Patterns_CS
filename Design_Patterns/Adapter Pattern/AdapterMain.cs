using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter_Pattern
{
    public class AdapterMain
    {
        public static void Main(string[] args)
        {
            string replyFromDavid = new EnglishSpeaker().AskQuestion("how are you?");
            Console.WriteLine("Reply From David [French Speaker can Speak and Understand only French] :  " + replyFromDavid);
            Console.WriteLine();
            string replyFromJohn = new FrenchSpeaker().AskQuestion("où êtes-vous?");
            Console.WriteLine("Reply From John [English Speaker can Speak and Understand only English] :  " + replyFromJohn);

            Console.Read();
        }
    }
}
