using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    internal class EcosystemMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which Ecosystem Do you want (jungle/savannah): ");
            string ecosystemName = Console.ReadLine();

            switch (ecosystemName.ToLower())
            {
                case "jungle":
                    var jungleFactory = new JungleFactory();
                    var jungle = new Ecosystem(jungleFactory);
                    jungle.RunFoodChain();
                    break;

                case "savannah":
                    var savannahFactory = new SavannahFactory();
                    var savannah = new Ecosystem(savannahFactory);
                    savannah.RunFoodChain();
                    break;

                default:
                    throw new ArgumentException("Invalid Ecosystem name");
            }
        }
    }
}
