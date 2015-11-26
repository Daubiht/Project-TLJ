using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class Merchant
    {

        readonly List<Item> _sellableItems;
        Invent _invent;
        string _name;
        
        // Constructor
        public Merchant(string name, List<Item> itemSellable)
        {
            _sellableItems = itemSellable;
            _name = name;
        }

        // Methodes

        // Buy an item
        public void BuyItems(Item ItemBought, int quantity)
        { 
            // calcul the total price
            int totalPrice = ItemBought.GetValue * quantity;

            // Check if the invent team has enought money
            if ( totalPrice < _invent.GetGold )
            {
                int compare = _invent.weight + (ItemBought.GetWeight*quantity);
                if (_invent.MaxWeight >= compare )
                {
                    _invent.AddItem(ItemBought, quantity);
                    _invent.RemoveGold(totalPrice);
                }
            }
        }

        // Sell an item
        public void SellItems(Item ItemSold)
        {
            _invent.AddGold(Convert.ToInt32(ItemSold.GetValue * 0.8));
            _invent.RemoveItem(ItemSold);
        }

        // Properties

        // Get list of items sellable
        public List<Item> GetItemsAvailable
        {
            get{ return _sellableItems; }
        }

        public Invent Invent
        {
            get { return _invent; }
            set { _invent = value;  }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
