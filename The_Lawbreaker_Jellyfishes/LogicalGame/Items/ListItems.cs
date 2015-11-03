﻿using System;
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
            Stream stream = new FileStream("../../../items.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Item> listItems = (List<Item>)formatter.Deserialize(stream);
            stream.Close();

            _listItems = listItems;
        }

        public List<Item> Items
        {
            get { return _listItems; }
        }
    }
}
