using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight_Pattern
{
    public class Tree
    {
        private readonly TreeType _treeType;
        private readonly int _x;
        private readonly int _y;
        public Tree(int x, int y, TreeType treeType)
        {
            _x = x;
            _y = y;
            _treeType = treeType;
        }
        public void Draw()
        {
            _treeType.Draw(_x, _y);
        }
    }
}
