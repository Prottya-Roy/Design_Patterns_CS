using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight_Pattern
{
    public class FlyweightMain
    {
        public static void Main()
        {
            var forest = new List<Tree>();
            forest.Add(new Tree(1, 2, TreeFactory.GetTreeType("Pine", "Green", "PineTexture")));
            forest.Add(new Tree(10, 20, TreeFactory.GetTreeType("Pine", "Green", "PineTexture")));
            forest.Add(new Tree(3, 4, TreeFactory.GetTreeType("Oak", "Brown", "OakTexture")));
            forest.Add(new Tree(5, 7, TreeFactory.GetTreeType("Oak", "Brown", "OakTexture")));
            forest.Add(new Tree(7, 9, TreeFactory.GetTreeType("Oak", "Brown", "OakTexture")));
            forest.Add(new Tree(12, 14, TreeFactory.GetTreeType("Oak", "Brown", "OakTexture")));
            forest.Add(new Tree(15, 19, TreeFactory.GetTreeType("Oak", "Brown", "OakTexture")));
            foreach (var tree in forest)
            {
                tree.Draw();
            }
            Console.ReadKey();
        }
    }
}
