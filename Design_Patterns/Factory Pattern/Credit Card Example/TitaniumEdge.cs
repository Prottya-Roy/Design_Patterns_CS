using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Pattern
{
    internal class TitaniumEdge : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "TitaniumEdge";
        }

        public int GetCreditCardLimit()
        {
            return 25000;
        }
    }
}
