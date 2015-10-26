using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
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
        readonly string _type;
        readonly Dictionary<string, int> _stats = new Dictionary<string, int>();
        readonly Dictionary<string, int> _required = new Dictionary<string, int>();

        public Item(string name, int weight, int value, string description, string type)
        {
            _name = name;
            _weight = weight;
            _value = value;
            _description = description;
            _type = type;
        }

        public void AddRequired(string name, int numb)
        {
            if (_required.ContainsKey(name))
            {
                _required[name] += numb;
            }
            else
            {
                _required.Add(name, numb);
            }
        }

        public void AddStats(string name, int numb)
        {
            if (_stats.ContainsKey(name))
            {
                _stats[name] += numb;
            }
            else
            {
                _stats.Add(name, numb);
            }
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

        public Dictionary<string, int> GetStats
        {
            get { return _stats; }
        }

        public Dictionary<string, int> GetRequired
        {
            get { return _required; }
        }

        public string Type
        {
            get { return _type; }
        }
    }
}
