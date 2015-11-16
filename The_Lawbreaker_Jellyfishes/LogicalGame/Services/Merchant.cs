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
        
        // Constructor
        public Merchant(Team currentTeam)
        {
            _currentTeam = currentTeam;
            ListItems l = new ListItems();
            _sellableItems = new List<Item>();
        }

        // Methodes

        // Buy an item
        public bool BuyItems(Item ItemBought, int quantity)
        {
            // check if the list of sellable items contains the wanted item
            if ( _sellableItems.Contains(ItemBought) )
            {   
                // calcul the total price
                int totalPrice = ItemBought.GetValue * quantity;
                int totalWeight = ItemBought.GetWeight;

                // Check if the invent team has enought money
                if ( totalPrice < _currentTeam.Invent.GetGold)
                {
                    _currentTeam.Invent.AddItem(ItemBought, quantity);
                    _currentTeam.Invent.RemoveGold(totalPrice);

                    return true;
                }
            }

            return false;
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

        public Item AddItem (Item item)
        {
            if (!_sellableItems.Contains(item))
            {
                _sellableItems.Add(item);
                return item;
            }
            return null;
        }


        // Temporary property for the MerchantTest 
        public Team Team
        {
            get { return _currentTeam; }
            set { _currentTeam = value;  }
        }
    }
}
