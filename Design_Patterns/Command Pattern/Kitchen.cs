using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Command_Pattern
{
    public class Kitchen
    {
        public void PrepareFish()
        {
            Console.WriteLine("Preparing Fish as per Order...");
        }

        public void PrepareBurger()
        {
            Console.WriteLine("Preparing Burger as per Order...");
        }

        public void PreparePasta()
        {
            Console.WriteLine("Preparing Pasta as per Order...");
        }

        public void PrepareMeat()
        {
            Console.WriteLine("Preparing Meat as per Order...");
        }
    }
}
