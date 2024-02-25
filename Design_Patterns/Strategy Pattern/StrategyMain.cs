using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy_Pattern
{
    public class StrategyMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Travel Type : \n1 for Auto \n2 for Bus \n3 for Train");
            int travelType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You Select Travel type : " + travelType);

            TravelContext ctx = new TravelContext();
           
            if (travelType == (int)TravelType.Bus)
            {
                ctx.SetTravelStrategy(new BusTravelStrategy());
            }
            else if (travelType == (int)TravelType.Train)
            {
                ctx.SetTravelStrategy(new TrainTravelStrategy());
            }
            else if (travelType == (int)TravelType.Auto)
            {
                ctx.SetTravelStrategy(new AutoTravelStrategy());
            }
            else
            {
                Console.WriteLine("You Select an Invalid Option");
            }

            ctx.Go();
            Console.Read();
        }

    }
    public enum TravelType
    {
        Auto = 1, 
        Bus = 2,  
        Train = 3, 
    }
}
