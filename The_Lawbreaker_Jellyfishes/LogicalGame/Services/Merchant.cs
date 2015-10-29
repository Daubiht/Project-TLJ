using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    class Merchant
    {
        ListItems _listOfAllItems;
        Team _currentTeam;
        MapCity _contextCity;


        // Constructor
        public Merchant(ListItems listOfAllItems, Team currentTeam, MapCity contextCity)
        {
            _listOfAllItems = listOfAllItems;
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

    }
}
