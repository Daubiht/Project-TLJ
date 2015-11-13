using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame
{
    [Serializable]
    public class Merchant
    {

        readonly List<Item> _sellableItems;
        Team _currentTeam;
        MapCity _contextCity;
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
            // check if the list of sellable items contains the wanted item
            if ( _sellableItems.Contains(ItemBought) )
            {   
                // calcul the total price
                int totalPrice = ItemBought.GetValue * quantity;

                // Check if the invent team has enought money
                if ( totalPrice < _currentTeam.Invent.GetGold )
                {
                    _currentTeam.Invent.AddItem(ItemBought, quantity);
                    _currentTeam.Invent.RemoveGold(totalPrice);
                }
            }
        }

        // Sell an item
        public void SellItems(Item ItemSold)
        {
            _currentTeam.Invent.AddGold(ItemSold.GetValue);
            _currentTeam.Invent.RemoveItem(ItemSold);
        }

        // Properties

        // Get list of items sellable
        public List<Item> GetItemsAvailable
        {
            get{ return _sellableItems; }
        }


        // Temporary property for the MerchantTest 
        public Team Team
        {
            get { return _currentTeam; }
            set { _currentTeam = value;  }
        }

        public string Name
        {
            get { return _name; }
        }

        public MapCity City
        {
            get { return _contextCity; }
            set { _contextCity = value; }
        }
    }
}
