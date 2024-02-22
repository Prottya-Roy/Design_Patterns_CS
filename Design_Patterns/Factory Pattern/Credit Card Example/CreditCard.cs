using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Pattern
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditCardLimit();
        int GetAnnualCharge();
    }
}
