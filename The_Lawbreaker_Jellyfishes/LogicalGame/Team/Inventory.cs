using System;
using System.Collections.Generic;

namespace LogicalGame
{
    /// <summary>
    /// Class that manage an inventory
    /// </summary>
    [Serializable]
    public class Invent
    {
        readonly Dictionary<Item, int> _inventory = new Dictionary<Item, int>();
        int _MaxWeight = 100;
        int _gold = 100;
        readonly Team _context;

        public Invent(Team context)
        {
            _context = context;
        }

        public Item AddItem(Item item, int quantity)
        {
            int additional = weight + (item.GetWeight * quantity);

            if (additional < _MaxWeight)
            {
                foreach (Item itemFromInvent in _inventory.Keys)
                {
                    if (item.GetName == itemFromInvent.GetName)
                    {
                        _inventory[itemFromInvent] += quantity;
                        return item;
                    }
                }
                _inventory.Add(item, quantity);
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

        public int MaxWeight
        {
            get { return _MaxWeight; }
        }

        public int weight
        {
            get
            {
                int w = 0;
                foreach (Item i in _inventory.Keys)
                {
                    w += i.GetWeight * _inventory[i];
                }
                return w;
            }
        }
    }
}
