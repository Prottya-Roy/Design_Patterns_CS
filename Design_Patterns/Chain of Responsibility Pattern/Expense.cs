using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Chain_of_Responsibility_Pattern
{
    public class Expense
    {
        public double amount {  get; set; }
        public Expense(double amount)
        {
            this.amount = amount;
        }
    }
}
