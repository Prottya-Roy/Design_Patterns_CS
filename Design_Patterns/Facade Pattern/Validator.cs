
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Facade_Pattern
{
    public class Validator
    {
        public bool ValidateCustomer(Customer customer)
        {
            Console.WriteLine("Customer Validated...");
            Console.WriteLine($"Name:{customer.Name}");
            Console.WriteLine($"Email:{customer.Email}");
            Console.WriteLine($"Mobile:{customer.MobileNumber}");
            Console.WriteLine($"Address:{customer.Address}");
            return true;
        }
    }
}
