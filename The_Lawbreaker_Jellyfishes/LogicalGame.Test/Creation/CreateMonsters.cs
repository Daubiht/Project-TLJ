﻿using NUnit.Framework;
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
    class CreateMonsters
    {
        [Test]
        public void Create_a_list_of_Monster_and_serializ_it()
        {
            List<Monster> listMonsters = new List<Monster>();

            Monster m1 = new Monster("Slime Immature", 1, "slime", 10, 0, 25, 0, 5, 5);
            m1.XP = 30;
            m1.Gold = 10;
            Monster m2 = new Monster("Behemoth", 100, "Démon", 1000, 1000, 100000, 10000, 60, 60);
            m2.XP = 10000;
            m2.Gold = 1000;
            Monster m3 = new Monster("Zombie rigolo", 3, "Undead", 20, 0, 100, 0, 5, 5);
            m3.XP = 50;
            m3.Gold = 30;
            Monster m4 = new Monster("Chaman Sombre", 4, "Mage", 100, 300, 4500, 10000, 50, 60);
            m4.XP = 800;
            m4.Gold = 500;

            listMonsters.Add(m1);
            listMonsters.Add(m2);
            listMonsters.Add(m3);
            listMonsters.Add(m4);

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/listMonsters.bin", FileMode.Create, FileAccess.Write,FileShare.None))
            {
                formatter.Serialize(stream, listMonsters);
            }
        }
    }
}
