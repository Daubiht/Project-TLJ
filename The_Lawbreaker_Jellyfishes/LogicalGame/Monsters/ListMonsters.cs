﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame
{
    [Serializable]
    public class ListMonsters
    {
        readonly List<Monster> _listMonsters = new List<Monster>();

        public ListMonsters()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("../../../Ressources/listMonsters.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Monster> listMonsters = (List<Monster>)formatter.Deserialize(stream);
            stream.Close();

            _listMonsters = listMonsters;
        }

        public List<Monster> GetListMonsters
        {
            get { return _listMonsters; }
        }
    }
}
