using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Chain_of_Responsibility_Pattern
{
    public abstract class AapprovalHandler
    {
        protected AapprovalHandler nextApprovalHandler;

        public void SetNext(AapprovalHandler nextApprovalHandler)
        {
            this.nextApprovalHandler = nextApprovalHandler;
        }

        public abstract void ApproveRequest(Expense expense);
    }
}
