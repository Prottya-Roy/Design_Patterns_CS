using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Chain_of_Responsibility_Pattern
{
    public class CEO : AapprovalHandler
    {
        public override void ApproveRequest(Expense expense)
        {
            if (expense.amount >=10000)
            {
                Console.WriteLine($"CEO Approved Expense of ${expense.amount}");
            }
            else
            {
                Console.WriteLine("Amount not allowed to be approved...");
            }
        }
    }
}
