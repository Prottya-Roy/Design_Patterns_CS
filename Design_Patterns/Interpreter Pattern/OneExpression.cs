using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Interpreter_Pattern
{
    public class OneExpression : AExpression
    {
        public override string Five() => "V";

        public override string Four() => "IV";

        public override int Multiplier() => 1;

        public override string Nine() => "IX";

        public override string One() => "I";
    }
}
