using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Chain_of_Responsibility_Pattern
{
    public class Manager : AapprovalHandler
    {
        public override void ApproveRequest(Expense expense)
        {
            if(expense.amount < 1000)
            {
                Console.WriteLine($"Manager Approved Expense of ${expense.amount}");
            }
            else if (expense.amount != null)
            {
                nextApprovalHandler.ApproveRequest(expense);
            }
        }
    }
}
