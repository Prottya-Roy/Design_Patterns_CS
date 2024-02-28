using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Chain_of_Responsibility_Pattern
{
    public class CoRMain 
    {
        public static void Main(string[] args)
        {
            Manager manager = new Manager();
            Director director = new Director();
            CEO cEO = new CEO();

            manager.SetNext(director);
            director.SetNext(cEO);

            var expense1 = new Expense(500);
            var expense2 = new Expense(5000);
            var expense3 = new Expense(15000);
            var expense4 = new Expense(25000);
            manager.ApproveRequest(expense1);
            manager.ApproveRequest(expense2);
            manager.ApproveRequest(expense3);
            manager.ApproveRequest(expense4);
            Console.ReadLine();
        }
    }
}
