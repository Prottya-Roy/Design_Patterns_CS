using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Memento_Pattern
{
    public class TransactionHistory
    {
        private Stack<TransactionMemento> _transactions = new Stack<TransactionMemento>();

        public void SaveState(BankAccount account)
        {
            _transactions.Push(account.CreateMemento());
        }
        public TransactionMemento UndoTransaction()
        {
            return _transactions.Pop();
        }
    }
}
