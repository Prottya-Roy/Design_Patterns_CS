using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Chain_of_Responsibility_Pattern
{
    public class Director : AapprovalHandler
    {
        public override void ApproveRequest(Expense expense)
        {
            if (expense.amount > 1000 && expense.amount<10000)
            {
                Console.WriteLine($"Director Approved Expense of ${expense.amount}");
            }
            else
            {
                nextApprovalHandler.ApproveRequest(expense);
            }
        }
    }
}
