using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Interpreter_Pattern
{
    public class HundredExpression : AExpression
    {
        public override string Five() => "D";

        public override string Four() => "CD";

        public override int Multiplier() => 100;

        public override string Nine() => "CM";

        public override string One() => "C";
    }
}
