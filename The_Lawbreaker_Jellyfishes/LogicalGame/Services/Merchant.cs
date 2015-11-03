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

        List<Item> _sellableItems = new List<Item>();
        Team _currentTeam;
        MapCity _contextCity;
        
        // Constructor
        public Merchant(Team currentTeam, MapCity contextCity)
        {
            ListItems l = new ListItems();
            
            if(contextCity.CityName == "Ponyo")
            {
                List<int> itemsSellable = new List<int>(0);
                _sellableItems = l.ItemsYouWant(itemsSellable);
            }
            else if (contextCity.CityName == "Gaz Town")
            {
                List<int> itemsSellable = new List<int>(1);
                _sellableItems = l.ItemsYouWant(itemsSellable);

            }
            else if (contextCity.CityName == "Ville perdue")
            {
                List<int> itemsSellable = new List<int>(2);
                _sellableItems = l.ItemsYouWant(itemsSellable);

            }
            else if (contextCity.CityName == "Laurento")
            {
                throw new NotImplementedException();
            }

            _currentTeam = currentTeam;
            _contextCity = contextCity;
        }

        // Methodes

        // Buy an item
        public void BuyItems(Item ItemBought, int quantity)
        {
            //_currentTeam.InventTeam.AddItem(ItemBought, quantity);
        }

        // Sell an item
        public void SellItems(Item ItemSold)
        {
            //_currentTeam.InventTeam.AddGold(ItemSold.GetValue);
            //_currentTeam.InventTeam.RemoveItem(ItemSold);
        }

        // Properties

        // Get list of items sellable
        public List<Item> GetItemsAvailable
        {
            get{ return _sellableItems; }
        }
    }
}
