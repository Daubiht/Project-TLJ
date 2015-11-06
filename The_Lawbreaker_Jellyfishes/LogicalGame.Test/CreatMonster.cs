using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame.Test
{
    [TestFixture]
    class CreatMonster
    {
        [Test]
        public void Creat_a_list_of_Monster_and_serializ_it ()
        {
            List<Monster> listMonsters = new List<Monster>();

            Monster m1 = new Monster("Slime Immature", "slime",10, 0, 100, 0, 5, 5);
            Monster m2 = new Monster("Behemoth", "Démon", 1000, 1000, 100000, 10000, 300, 200);
            Monster m3 = new Monster("Zombie rigolo", "Undead", 20, 0, 500, 0, 5, 5);
            Monster m4 = new Monster("Chaman Sombre", "Mage", 100, 300, 4500, 10000, 50, 100);

            listMonsters.Add(m1);
            listMonsters.Add(m2);
            listMonsters.Add(m3);
            listMonsters.Add(m4);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("../../../listMonsters.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, listMonsters);
            stream.Close();
        }
    }
}
