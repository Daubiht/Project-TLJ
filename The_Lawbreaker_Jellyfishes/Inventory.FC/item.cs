using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.FC
{
    /// <summary>
    /// Class that creates objet item with a name, weight, value, description, bonus stat and required stat
    /// </summary>
    public class Item
    {
        readonly string _name;
        readonly int _weight;
        readonly int _value;
        readonly string _description;
        readonly Dictionary<string, int> _stats = new Dictionary<string, int>();
        readonly Dictionary<string, int> _required = new Dictionary<string, int>();

        public Item(string name, int weight, int value, string description, int statsNumbers, string statsNames, string requiredNames, int requiredNumbers)
        {
            _name = name;
            _weight = weight;
            _value = value;
            _description = description;
            _stats.Add(statsNames, statsNumbers);
            _required.Add(requiredNames, requiredNumbers);
        }

        public string GetName
        {
            get { return _name; }
        }

        public int GetWeight
        {
            get { return _weight; }
        }

        public int GetValue
        {
            get { return _value; }
        }

        public string GetDescription
        {
            get { return _description; }
        }

        public Dictionary<string, int> GetStatsBonus
        {
            get { return _stats; }
        }

        public Dictionary<string, int> GetRequired
        {
            get { return _required; }
        }
    }
}
