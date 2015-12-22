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
    class CreateMonsters
    {
        [Test]
        public void Create_a_list_of_Monster_and_serializ_it()
        {
            List<Monster> listMonsters = new List<Monster>();
            ListItems item = new ListItems();

            Monster m1 = new Monster("Slime Immature", 1, "slime", 10, 0, 25, 0, 5, 5);
            m1.XP = 30;
            m1.Gold = 10;
            m1.AddItemToDrop(item.Items[4], 60);
            m1.AddItemToDrop(item.Items[6], 60);
            Monster m5 = new Monster("Slime", 2, "slime", 10, 0, 40, 0, 5, 5);
            m5.XP = 55;
            m5.Gold = 20;
            m5.AddItemToDrop(item.Items[5], 60);
            Monster m6 = new Monster("Grand Slime", 4, "slime", 10, 0, 70, 0, 5, 5);
            m6.XP = 70;
            m6.Gold = 30;
            m6.AddItemToDrop(item.Items[4], 60);
            Monster m2 = new Monster("Behemoth", 10000, "Démon", 1000, 1000, 100000, 10000, 60, 60);
            m2.XP = 10000;
            m2.Gold = 1000;
            Monster m3 = new Monster("Zombie rigolo", 3, "Undead", 20, 0, 100, 0, 5, 5);
            m3.XP = 50;
            m3.Gold = 30;
            m1.AddItemToDrop(item.Items[4], 60);
            m1.AddItemToDrop(item.Items[5], 60);
            m1.AddItemToDrop(item.Items[6], 60);
            Monster m4 = new Monster("Chaman Sombre", 4, "Mage", 100, 300, 4500, 10000, 50, 60);
            m4.XP = 800;
            m4.Gold = 500;

            listMonsters.Add(m1);
            listMonsters.Add(m2);
            listMonsters.Add(m3);
            listMonsters.Add(m4);
            listMonsters.Add(m5);
            listMonsters.Add(m6);

            // Jerome
            // Spider
            Monster m7 = new Monster("Arraignee bébé", 1, "Arraignee", 5, 0, 55, 0, 0, 0);
            m7.XP = 20;
            m7.Gold = 15;
            m7.AddItemToDrop(item.Items[4], 60);

            Monster m8 = new Monster("Arraignee adulte", 1, "Arraignee", 10, 0, 100, 0, 0, 0);
            m8.XP = 50;
            m8.Gold = 20;
            m8.AddItemToDrop(item.Items[4], 60);

            Monster m9 = new Monster("Arraignee Reine", 1, "Arraignee", 20, 0, 200, 0, 0, 0);
            m9.XP = 70;
            m9.Gold = 60;
            m9.AddItemToDrop(item.Items[4], 60);
            // Bees
            Monster m10 = new Monster("Abeille jaune", 1, "Abeille", 4, 0, 45, 1, 0, 1);
            m10.XP = 20;
            m10.Gold = 15;
            m10.AddItemToDrop(item.Items[4], 60);

            Monster m11 = new Monster("Abeille rouge", 1, "Abeille", 4,4, 45, 1, 0, 1);
            m11.XP = 20;
            m11.Gold = 15;
            m11.AddItemToDrop(item.Items[4], 60);

            Monster m12 = new Monster("Abeille tueuse", 1, "Abeille", 4, 7, 60, 1, 0, 1);
            m12.XP = 20;
            m12.Gold = 20;
            m12.AddItemToDrop(item.Items[4], 60);
            // Bats
            Monster m13 = new Monster("Mini chauve souris", 1, "Chauve souris", 8, 0, 60, 1, 0, 0);
            m13.XP = 25;
            m13.Gold = 25;
            m13.AddItemToDrop(item.Items[4], 60);

            Monster m14 = new Monster("Feroce chauve souris", 1, "Chauve souris", 10, 0, 75, 1, 0, 1);
            m14.XP = 25;
            m14.Gold = 27;
            m14.AddItemToDrop(item.Items[4], 60);

            Monster m15 = new Monster("Geante chauve souris", 1, "Chauve souris", 10, 10, 75, 3, 0, 1);
            m15.XP = 35;
            m15.Gold = 23;
            m15.AddItemToDrop(item.Items[4], 60);
            // Wolf
            Monster m16 = new Monster("Loup de feu", 1, "Loup", 8, 8, 75, 1, 0, 1);
            m16.XP = 35;
            m16.Gold = 23;
            m16.AddItemToDrop(item.Items[4], 60);

            Monster m17 = new Monster("Loup robuste", 1, "Loup", 10, 0, 110, 0, 2, 0);
            m17.XP = 35;
            m17.Gold = 23;
            m17.AddItemToDrop(item.Items[4], 60);

            Monster m18 = new Monster("Loup agile", 1, "Loup", 15, 0, 80, 1, 0, 2);
            m18.XP = 35;
            m18.Gold = 23;
            m18.AddItemToDrop(item.Items[4], 60);
            // Poring
            Monster m19 = new Monster("Thibaud lache", 1, "Poring", 1, 0, 1, 0, 0, 4);
            m19.XP = 1;
            m19.Gold = 1;
            m19.AddItemToDrop(item.Items[4], 60);
            Monster m20 = new Monster("Leo fragile", 1, "Poring", 1, 0, 1, 0, 0, 4);
            m20.XP = 1;
            m20.Gold = 1;
            m20.AddItemToDrop(item.Items[4], 60);
            Monster m21 = new Monster("Jerome le Grand", 1, "Poring", 10000, 0, 10000, 0, 0, 10000);
            m21.XP = 1000;
            m21.Gold = 1000;
            m21.AddItemToDrop(item.Items[4], 60);
            Monster m22 = new Monster("Dangereux", 1, "Poring", 65, 0, 1, 0, 0, 20);
            m22.XP = 1000;
            m22.Gold = 1000;
            m22.AddItemToDrop(item.Items[4], 60);
            // Dead
            Monster m23 = new Monster("Chien mort", 1, "Mort", 8, 0, 55, 1, 1, 1);
            m23.XP = 1000;
            m23.Gold = 1000;
            m23.AddItemToDrop(item.Items[4], 60);
            Monster m24 = new Monster("Loup mort", 1, "Mort", 13, 0, 70, 1, 2, 1);
            m24.XP = 1000;
            m24.Gold = 1000;
            m24.AddItemToDrop(item.Items[4], 60);
            Monster m25 = new Monster("Squelette", 1, "Mort", 15, 0, 75, 2, 2, 0);
            m25.XP = 1000;
            m25.Gold = 1000;
            m25.AddItemToDrop(item.Items[4], 60);
            Monster m26 = new Monster("Fantome", 1, "Mort", 15, 15, 70, 4, 2, 0);
            m26.XP = 1000;
            m26.Gold = 1000;
            m26.AddItemToDrop(item.Items[4], 60);
            // Plant
            Monster m27 = new Monster("Carnivore", 1, "Plante", 15, 0, 80, 0, 1, 0);
            m27.XP = 1000;
            m27.Gold = 1000;
            m27.AddItemToDrop(item.Items[4], 60);
            Monster m28 = new Monster("Soporiphiqe", 1, "Plante", 20, 20, 80, 5, 1, 0);
            m28.XP = 1000;
            m28.Gold = 1000;
            m28.AddItemToDrop(item.Items[4], 60);
            Monster m29 = new Monster("Arbre démoniaque", 1, "Plante", 35, 0, 170, 3, 3, 0);
            m29.XP = 1000;
            m29.Gold = 1000;
            m29.AddItemToDrop(item.Items[4], 60);
            // Robot
            Monster m30 = new Monster("RX 100", 1, "Machine", 17, 0, 135, 4, 3, 0);
            m30.XP = 1000;
            m30.Gold = 1000;
            m30.AddItemToDrop(item.Items[4], 60);

            Monster m31 = new Monster("RX 50", 1, "Machine", 10, 0, 80, 2, 2, 0);
            m31.XP = 1000;
            m31.Gold = 1000;
            m31.AddItemToDrop(item.Items[4], 60);

            Monster m32 = new Monster("Lanceur", 1, "Machine", 15, 0, 70, 3, 1, 0);
            m32.XP = 1000;
            m32.Gold = 1000;
            m32.AddItemToDrop(item.Items[4], 60);
            // Dragon
            Monster m33 = new Monster("Legendaire", 1, "Dragon", 25, 0, 200, 3, 2, 2);
            m33.XP = 1000;
            m33.Gold = 1000;
            m33.AddItemToDrop(item.Items[4], 60);
            // Cat
            Monster m34 = new Monster("Tigrou", 1, "Chat", 15, 0, 150, 0, 0, 20);
            m34.XP = 1000;
            m34.Gold = 1000;
            m34.AddItemToDrop(item.Items[4], 60);
            // Gobelin
            Monster m35 = new Monster("Gobelin sauvage", 1, "Gobelin", 12, 0, 80, 2, 1, 1);
            m35.XP = 1000;
            m35.Gold = 1000;
            m35.AddItemToDrop(item.Items[4], 60);

            Monster m36 = new Monster("Gobelin lache", 1, "Gobelin", 12, 0, 60, 2, 1, 10);
            m36.XP = 1000;
            m36.Gold = 1000;
            m36.AddItemToDrop(item.Items[4], 60);

            Monster m37 = new Monster("Super gobelin", 1, "Gobelin", 15, 0, 100, 3, 3, 2);
            m37.XP = 1000;
            m37.Gold = 1000;
            m37.AddItemToDrop(item.Items[4], 60);

            Monster m38 = new Monster("Roi des gobelins", 1, "Gobelin", 30, 0, 300, 4, 4, 2);
            m38.XP = 1000;
            m38.Gold = 1000;
            m38.AddItemToDrop(item.Items[4], 60);
            // Bird
            Monster m39 = new Monster("Aigle", 1, "Oiseau", 10, 0, 20, 2, 0, 2);
            m39.XP = 1000;
            m39.Gold = 1000;
            m39.AddItemToDrop(item.Items[4], 60);
            // Bear
            Monster m40 = new Monster("Ours brun", 1, "Ours", 15, 0, 80, 2, 0, 2);
            m40.XP = 1000;
            m40.Gold = 1000;
            m40.AddItemToDrop(item.Items[4], 60);

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/listMonsters.bin", FileMode.Create, FileAccess.Write,FileShare.None))
            {
                formatter.Serialize(stream, listMonsters);
            }
        }
    }
}
