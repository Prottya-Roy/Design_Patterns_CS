using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Pattern
{
    class FactoryDesign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Card Type Wanted : ");
            string cardType = Console.ReadLine();

            CreditCard card = CreditCardFactory.GetCreditCard(cardType);

            if (card != null)
            {
                Console.WriteLine("Card Limit : " + card.GetCreditCardLimit());
                Console.WriteLine("Annual Charge : " + card.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine(Console.ReadLine());
            }
        }
    }
}
