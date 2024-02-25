using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Facade_Pattern
{
    public class FacadeMain
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Name = "Prottya",
                Email = "a@gmail.com",
                MobileNumber = "1234567890",
                Address = "Dhaka"
            };
            Validator validator = new Validator();
            bool IsValid = validator.ValidateCustomer(customer);
            CustomerDataAccessLayer customerDataAccessLayer = new CustomerDataAccessLayer();
            bool IsSaved = customerDataAccessLayer.SaveCustomer(customer);
            Email email = new Email();
            email.SendRegistrationEmail(customer);
            Console.ReadKey();
        }
    }
}
