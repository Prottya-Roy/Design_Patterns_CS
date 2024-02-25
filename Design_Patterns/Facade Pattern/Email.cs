using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Facade_Pattern
{
    public class Email
    {
        public bool SendRegistrationEmail(Customer customer)
        {
            Console.WriteLine("\nRegistration Email Send to Customer...");
            return true;
        }
    }
}
