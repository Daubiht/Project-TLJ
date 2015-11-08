using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame
{
    public class ListItems
    {
        readonly List<Item> _listItems = new List<Item>();

        public ListItems()
        {
            IFormatter formatter = new BinaryFormatter();
            List<Item> listItems;
            using (Stream stream = new FileStream("../../../Ressources/items.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                listItems = (List<Item>) formatter.Deserialize(stream);
            }

            _listItems = listItems;
        }

        public List<Item> Items
        {
            get { return _listItems; }
        }

        public List<Item> ItemsYouWant (List<int> listInt)
        {
            List<Item> items = new List<Item>(); 

            for (int i = 0; i < listInt.Count; i++)
            {
                items.Add(_listItems[listInt[i]]);
            }
            return items;
        }
    }
}
