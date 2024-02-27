using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Memento_Pattern
{
    public class MementoMain
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000);
            TransactionHistory history = new TransactionHistory();

            account.Deposit(500);
            history.SaveState(account);

            account.Withdraw(600);
            history.SaveState(account);

            account.Deposit(1100);

            account.RestoreFromMemento(history.UndoTransaction());

            Console.WriteLine($"Current Balance = {account.Balance}");

            Console.ReadKey();
        }
    }
}
