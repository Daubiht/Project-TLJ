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
        int _x;
        int _y;
        
        // Constructor
        public Merchant(string name, List<Item> itemSellable)
        {
            _sellableItems = itemSellable;
            _name = name;
        }

        // Methodes

        //Count of the price of an item in this merchant with the actual team
        public int ItemToBuyPrice (Item item)
        {
            int price = 0;
            Dictionary<string, List<string>> augmentation = new Dictionary<string, List<string>>();
            bool increase = true;
            List<string> merchantName = new List<string>();

            merchantName.Add("arme");
            merchantName.Add("jambes");
            merchantName.Add("corps");
            merchantName.Add("tete");
            augmentation.Add("forgeron", merchantName);

            merchantName.Clear();
            merchantName.Add("consommable");
            augmentation.Add("herboriste", merchantName);

            merchantName.Clear();
            augmentation.Add("Vendeur général", merchantName);

            for (int i = 0; i < augmentation[_name].Count; i++)
            {
                if (augmentation[_name][i] == item.Type) increase = false;
            }

            if (increase == true) return (int)Math.Round(item.GetValue -item.GetValue * countReduce() + item.GetValue * 0.2);

            return (int)Math.Round(item.GetValue - item.GetValue * countReduce());
        }


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
            int totalPrice = ItemToBuyPrice(ItemBought) * quantity;

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
