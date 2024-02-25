using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight_Pattern
{
    public class TreeFactory
    {
        private static readonly Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();
        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var key = $"{name}_{color}_{texture}";
            if (!_treeTypes.ContainsKey(key))
            {
                var type = new TreeType(name, color, texture);
                _treeTypes.Add(key, type);
            }
            return _treeTypes[key];
        }
    }
}
