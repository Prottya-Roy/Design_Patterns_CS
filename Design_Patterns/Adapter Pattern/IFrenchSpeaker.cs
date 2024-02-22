using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter_Pattern
{
    internal interface IFrenchSpeaker
    {
        string AskQuestion(string Words);
        string AnswerFortheQuestion(string Words);
    }
}
