﻿using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class Merchant
    {

        readonly List<Item> _sellableItems;
        Invent _invent;
        string _name;
        int _x;
        int _y;
        
        // Constructor
        public Merchant(string name, List<Item> itemSellable)
        {
            _sellableItems = itemSellable;
            _name = name;
        }

        // Methodes

        //Count of Reduce
        private double countReduce()
        {
            int count = 0;
            foreach (Character chara in _invent.Context.Members)
            {
                if (chara.Race == "Human" || chara.Race == "human" || chara.Race == "Humain")
                {
                    count++;
                }
            }
            return count * 0.05;
        }

        // Buy an item
        public void BuyItems(Item ItemBought, int quantity)
        { 
            // calcul the total price
            int totalPrice = ItemBought.GetValue * quantity;

            // Check if the invent team has enought money
            if (totalPrice < _invent.GetGold)
            {
                int compare = _invent.weight + (ItemBought.GetWeight*quantity);
                if (_invent.MaxWeight >= compare )
                {
                    _invent.AddItem(ItemBought, quantity);
                    _invent.RemoveGold(totalPrice - (int)(Math.Round(countReduce()*totalPrice)));
                }
            }
        }

        // Sell an item
        public void SellItems(Item ItemSold)
        {
            _invent.AddGold(Convert.ToInt32(ItemSold.GetValue * 0.8) + (int)(Math.Round(countReduce() * Convert.ToInt32(ItemSold.GetValue * 0.8))));
            _invent.RemoveItem(ItemSold);
        }

        // Properties

        // Get list of items sellable
        public int PointX
        {
            get { return _x; }
            set { _x = value; }
        }
        public int PointY
        {
            get { return _y; }
            set { _y = value; }
        }

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
