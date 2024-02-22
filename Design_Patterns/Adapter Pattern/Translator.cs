using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter_Pattern
{
    internal class Translator : ITranslator
    {
        static Dictionary<string, string> EnglishFrenchDictionary = new Dictionary<string, string>();
        static Dictionary<string, string> FrenchEnglishDictionary = new Dictionary<string, string>();
        FrenchSpeaker frenchSpeaker = new FrenchSpeaker();
        EnglishSpeaker englishSpeaker = new EnglishSpeaker();

        static Translator()
        {
            EnglishFrenchDictionary.Add("how are you?", "comment allez-vous?");
            EnglishFrenchDictionary.Add("I am in USA", "Je suis aux Etats-Unis");
            EnglishFrenchDictionary.Add("where are you?", "où êtes-vous?");
            FrenchEnglishDictionary.Add("où êtes-vous?", "where are you?");
            FrenchEnglishDictionary.Add("Je suis très bien", "I am fine");
            FrenchEnglishDictionary.Add("oC9 C*tes-vous?", "where are you?");
        }
        public string TranslateAndTellToOtherPerson(string Words, string ConvertToWhichLanguage)
        {
            if (ConvertToWhichLanguage.Equals("English", StringComparison.InvariantCultureIgnoreCase))
            {
                string EnglishWords = ConvertToEnglish(Words);
                Console.WriteLine("\nTranslator Converted \"" + Words + " \" to \"" + EnglishWords + " and send the question to EnglishSpeaker");
                string EnglishWordsReply = englishSpeaker.AnswerFortheQuestion(EnglishWords);
                Console.WriteLine("Translator Got reply from EnglishSpeaker in English : " + "\"" + EnglishWordsReply + "\"");
                string FrenchConverted = ConvertToFrench(EnglishWordsReply);
                Console.WriteLine("Translator Converted " + "\"" + EnglishWordsReply + "\"" + " to " + "\"" + FrenchConverted + "\"" + " and send back to FrenchSpeaker\n");
                return FrenchConverted;
            }
            else if (ConvertToWhichLanguage.Equals("French", StringComparison.InvariantCultureIgnoreCase))
            {
                string FrenchWords = ConvertToFrench(Words);
                Console.WriteLine("\nTranslator Converted \"" + Words + " \" to \"" + FrenchWords + " and send the question to FrenchSpeaker");
                string FrenchWordsReply = frenchSpeaker.AnswerFortheQuestion(FrenchWords);
                Console.WriteLine("Translator Got reply from FrenchSpeaker in French : " + "\"" + FrenchWordsReply + "\"");
                string EnglishConverted = ConvertToEnglish(FrenchWordsReply);
                Console.WriteLine("Translator Converted " + "\"" + FrenchWordsReply + "\"" + " to " + "\"" + EnglishConverted + "\"" + " and send back to EnglishSpeaker\n");
                return EnglishConverted;
            }
            else
            {
                return "Sorry Cannot Covert";
            }
        }
        public string ConvertToFrench(string Words)
        {
            return EnglishFrenchDictionary[Words];
        }
        public string ConvertToEnglish(string Words)
        {
            return FrenchEnglishDictionary[Words];
        }
    }
}
