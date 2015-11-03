using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame
{
    public class ListMonsters
    {
        readonly List<Monster> _listMonsters = new List<Monster>();

        public ListMonsters()
        {
            IFormatter formatter = new BinaryFormatter();
            List<Monster> listMonsters;
            using (Stream stream = new FileStream("../../../monsters.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                listMonsters = (List<Monster>) formatter.Deserialize(stream);
            }

            _listMonsters = listMonsters;
        }

        public List<Monster> GetListMonsters
        {
            get { return _listMonsters; }
        }
    }
}
