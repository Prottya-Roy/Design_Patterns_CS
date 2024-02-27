using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Memento_Pattern
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public TransactionMemento CreateMemento()
        {
            return new TransactionMemento(Balance);
        }
        public void RestoreFromMemento(TransactionMemento memento)
        {
            this.Balance = memento.Balance;
        }
    }
}
