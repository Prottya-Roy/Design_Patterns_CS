using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Interpreter_Pattern
{
    public class TenExpression : AExpression
    {
        public override string Five() => "L";

        public override string Four() => "XL";

        public override int Multiplier() => 10;

        public override string Nine() => "XC";

        public override string One() => "X";
    }
}
