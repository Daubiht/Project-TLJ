using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame
{
    /// <summary>
    /// Class that manage an inventory
    /// </summary>
    [Serializable]
    public class Invent
    {
        readonly Dictionary<Item, int> _inventory = new Dictionary<Item, int>();
        int _weight = 100;
        int _gold = 0;
        readonly Team _context;

        public Invent(Team context)
        {
            _context = context;
        }

        public Item AddItem(Item item, int quantity)
        {
            int additional = 0;
            foreach (Item items in _inventory.Keys)
            {
                additional += items.GetWeight;
            }

            if (additional < _weight)
            {
                if (_inventory.ContainsKey(item))
                {
                    _inventory[item] = quantity;
                }
                else
                {
                    _inventory.Add(item, quantity);
                }

                return item;
            }
            return null;
        }

        public int RemoveItem(Item item)
        {
            if ( _inventory.ContainsKey(item)) { 
                if(_inventory[item] > 1)
                {
                    _inventory[item]--;
                    return _inventory[item];
                }
                else if(_inventory[item] == 1)
                {
                    _inventory.Remove(item);
                    return 0;
                }
            }
            throw new Exception();
        }

        public int RemoveGold(int RemoveGold)
        {
            return _gold -= RemoveGold;
        }

        public int AddGold(int AddGold)
        {
            return _gold += AddGold;
        }

        public int GetGold
        {
            get { return _gold; }
        }

        public bool GetItem(Item item)
        {
            if (_inventory.ContainsKey(item))
            {
                return true;
            }
            return false;
        }

        public Dictionary<Item,int> Inventory
        {
            get { return _inventory; }
        }
    }
}
