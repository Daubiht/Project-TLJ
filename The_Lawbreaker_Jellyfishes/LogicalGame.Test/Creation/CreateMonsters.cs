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

            //listMonsters.Add(m1);
            //listMonsters.Add(m2);
            //listMonsters.Add(m3);
            //listMonsters.Add(m4);
            //listMonsters.Add(m5);
            //listMonsters.Add(m6);

            // Jerome
            // Spider
            Monster m7 = new Monster("Arraignee bebe", 1, "Spider", 5, 0, 55, 0, 0, 0);
            m7.XP = 20;
            m7.Gold = 7;
            m7.AddItemToDrop(item.Items[4], 60);

            Monster m8 = new Monster("Arraignee adulte", 2, "Spider", 10, 0, 100, 0, 0, 0);
            m8.XP = 25;
            m8.Gold = 10;
            m8.AddItemToDrop(item.Items[4], 60);

            Monster m9 = new Monster("Arraignee Reine", 2, "Spider", 20, 0, 200, 0, 0, 0);
            m9.XP = 70;
            m9.Gold = 50;
            m9.AddItemToDrop(item.Items[4], 60);
            // Bees
            Monster m10 = new Monster("Petite abeille", 1, "Bee", 4, 0, 45, 1, 0, 1);
            m10.XP = 20;
            m10.Gold = 15;
            m10.AddItemToDrop(item.Items[4], 60);

            Monster m11 = new Monster("Grande abeille", 2, "Bee", 4, 4, 45, 1, 0, 1);
            m11.XP = 20;
            m11.Gold = 15;
            m11.AddItemToDrop(item.Items[4], 60);

            Monster m12 = new Monster("Abeille tueuse", 2, "Bee", 4, 7, 60, 1, 0, 1);
            m12.XP = 30;
            m12.Gold = 20;
            m12.AddItemToDrop(item.Items[4], 60);
            // Bats
            Monster m13 = new Monster("Mini chauve souris", 1, "Bat", 8, 0, 60, 1, 0, 0);
            m13.XP = 25;
            m13.Gold = 13;
            m13.AddItemToDrop(item.Items[4], 60);

            Monster m14 = new Monster("Chauve souris féroce", 2, "Bat", 10, 0, 75, 1, 0, 1);
            m14.XP = 35;
            m14.Gold = 20;
            m14.AddItemToDrop(item.Items[4], 60);

            Monster m15 = new Monster("Chauve souris sauvage", 2, "Bat", 10, 10, 75, 3, 0, 1);
            m15.XP = 50;
            m15.Gold = 30;
            m15.AddItemToDrop(item.Items[4], 60);
            // Wolf
            Monster m16 = new Monster("Louveteau", 2, "Wolf", 8, 8, 75, 1, 0, 1);
            m16.XP = 50;
            m16.Gold = 30;
            m16.AddItemToDrop(item.Items[4], 60);

            Monster m17 = new Monster("Loup robuste", 3, "Wolf", 10, 0, 110, 0, 2, 0);
            m17.XP = 60;
            m17.Gold = 40;
            m17.AddItemToDrop(item.Items[4], 60);

            Monster m18 = new Monster("Loup agile", 3, "Wolf", 15, 0, 80, 1, 0, 2);
            m18.XP = 60;
            m18.Gold = 25;
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
            Monster m21 = new Monster("Jerome le Puissant", 1, "Poring", 10000, 0, 10000, 0, 0, 10000);
            m21.XP = 1000;
            m21.Gold = 1000;
            m21.AddItemToDrop(item.Items[4], 60);
            Monster m22 = new Monster("Poring dangereux", 2, "Poring", 65, 0, 1, 0, 0, 20);
            m22.XP = 1000;
            m22.Gold = 1000;
            m22.AddItemToDrop(item.Items[4], 60);
            // Dead
            Monster m23 = new Monster("Lapin demoniaque", 3, "Dead", 8, 0, 55, 1, 1, 1);
            m23.XP = 55;
            m23.Gold = 30;
            m23.AddItemToDrop(item.Items[4], 60);
            Monster m24 = new Monster("Sanglier mort", 3, "Dead", 13, 0, 70, 1, 2, 1);
            m24.XP = 70;
            m24.Gold = 40;
            m24.AddItemToDrop(item.Items[4], 60);
            Monster m25 = new Monster("Squelette", 3, "Dead", 15, 0, 75, 2, 2, 0);
            m25.XP = 70;
            m25.Gold = 40;
            m25.AddItemToDrop(item.Items[4], 60);
            Monster m26 = new Monster("Fantome", 4, "Dead", 15, 15, 70, 4, 2, 0);
            m26.XP = 65;
            m26.Gold = 35;
            m26.AddItemToDrop(item.Items[4], 60);

            Monster m49 = new Monster("Faucheuse", 4, "Dead", 30, 0, 70, 4, 2, 20);
            m49.XP = 65;
            m49.Gold = 45;
            m49.AddItemToDrop(item.Items[4], 60);
            // Plant
            Monster m27 = new Monster("Plante tentaculaire", 4, "Plant", 15, 0, 80, 0, 1, 0);
            m27.XP = 65;
            m27.Gold = 30;
            m27.AddItemToDrop(item.Items[4], 60);
            Monster m28 = new Monster("Arbre démoniaque", 4, "Plant", 20, 20, 80, 5, 1, 0);
            m28.XP = 70;
            m28.Gold = 40;
            m28.AddItemToDrop(item.Items[4], 60);
            Monster m29 = new Monster("Ame des plantes", 4, "Plant", 35, 0, 170, 3, 3, 0);
            m29.XP = 190;
            m29.Gold = 150;
            m29.AddItemToDrop(item.Items[4], 60);
            // Robot
            Monster m30 = new Monster("RX 2000", 4, "Robot", 17, 0, 135, 4, 3, 0);
            m30.XP = 80;
            m30.Gold = 50;
            m30.AddItemToDrop(item.Items[4], 60);

            Monster m31 = new Monster("RX 50", 4, "Robot", 10, 0, 80, 2, 2, 0);
            m31.XP = 60;
            m31.Gold = 37;
            m31.AddItemToDrop(item.Items[4], 60);

            Monster m32 = new Monster("Lanceur", 4, "Robot", 15, 0, 70, 3, 1, 0);
            m32.XP = 50;
            m32.Gold = 30;
            m32.AddItemToDrop(item.Items[4], 60);
            // Dragon
            Monster m33 = new Monster("Dragon legendaire", 5, "Dragon", 25, 0, 200, 3, 2, 2);
            m33.XP = 250;
            m33.Gold = 190;
            m33.AddItemToDrop(item.Items[4], 60);
            // Cat
            Monster m34 = new Monster("Tigrou", 3, "Cat", 15, 0, 150, 0, 0, 20);
            m34.XP = 30;
            m34.Gold = 100;
            m34.AddItemToDrop(item.Items[4], 60);
            // Gobelin
            Monster m35 = new Monster("Gobelin epeiste", 3, "Gobelin", 12, 0, 80, 2, 1, 1);
            m35.XP = 60;
            m35.Gold = 25;
            m35.AddItemToDrop(item.Items[4], 60);

            Monster m36 = new Monster("Gobelin lache", 3, "Gobelin", 12, 0, 60, 2, 1, 10);
            m36.XP = 40;
            m36.Gold = 20;
            m36.AddItemToDrop(item.Items[4], 60);

            Monster m37 = new Monster("Super gobelin", 4, "Gobelin", 15, 0, 100, 3, 3, 2);
            m37.XP = 70;
            m37.Gold = 55;
            m37.AddItemToDrop(item.Items[4], 60);

            Monster m38 = new Monster("Roi des gobelins", 5, "Gobelin", 30, 0, 300, 4, 4, 2);
            m38.XP = 250;
            m38.Gold = 230;
            m38.AddItemToDrop(item.Items[4], 60);
            // Bird
            Monster m39 = new Monster("Aigle", 1, "Bird", 10, 0, 20, 2, 0, 2);
            m39.XP = 20;
            m39.Gold = 7;
            m39.AddItemToDrop(item.Items[4], 60);
            // Bear
            Monster m40 = new Monster("Ours brun", 3, "Bear", 15, 0, 80, 1, 2, 1);
            m40.XP = 50;
            m40.Gold = 30;
            m40.AddItemToDrop(item.Items[4], 60);
            // Human
                // Thiefs
            Monster m41 = new Monster("Frappeur", 3, "Thief", 20, 0, 70, 2, 1, 1);
            m41.XP = 60;
            m41.Gold = 35;
            m41.AddItemToDrop(item.Items[4], 60);

            Monster m50 = new Monster("Hacheur", 3, "Thief", 20, 0, 70, 2, 1, 1);
            m50.XP = 60;
            m50.Gold = 35;
            m50.AddItemToDrop(item.Items[4], 60);

            Monster m51 = new Monster("Griffeur", 3, "Thief", 20, 0, 70, 2, 1, 1);
            m51.XP = 60;
            m51.Gold = 35;
            m51.AddItemToDrop(item.Items[4], 60);

            Monster m52 = new Monster("Trancheur", 3, "Thief", 20, 0, 70, 2, 1, 1);
            m52.XP = 60;
            m52.Gold = 35;
            m52.AddItemToDrop(item.Items[4], 60);

            Monster m53 = new Monster("Decoupeur", 3, "Thief", 20, 0, 70, 2, 1, 1);
            m52.XP = 60;
            m52.Gold = 35;
            m52.AddItemToDrop(item.Items[4], 60);

            Monster m42 = new Monster("Chef des brigrands", 3, "Thief", 35, 0, 160, 4, 3, 10);
            m42.XP = 150;
            m42.Gold = 110;
            m42.AddItemToDrop(item.Items[4], 60);

            // Pirates
            Monster m43 = new Monster("Capitaine", 2, "Pirate", 11, 11, 100, 3, 2, 10);
            m43.XP = 70;
            m43.Gold = 45;
            m43.AddItemToDrop(item.Items[4], 60);
            Monster m44 = new Monster("Officier", 2, "Pirate", 10, 10, 85, 2, 2, 1);
            m44.XP = 60;
            m44.Gold = 35;
            m44.AddItemToDrop(item.Items[4], 60);
            Monster m45 = new Monster("Tireur", 2, "Pirate", 9, 9, 75, 1, 0, 1);
            m45.XP = 45;
            m45.Gold = 25;
            m45.AddItemToDrop(item.Items[4], 60);
            Monster m46 = new Monster("Matelot", 2, "Pirate", 8, 0, 60, 1, 0, 1);
            m46.XP = 40;
            m46.Gold = 25;
            m46.AddItemToDrop(item.Items[4], 60);
             // Merchant
            Monster m47 = new Monster("Marchand", 1, "Merchant", 4, 4, 60, 1, 0, 1);
            m47.XP = 40;
            m47.Gold = 25;
            m47.AddItemToDrop(item.Items[4], 60);

            Monster m48 = new Monster("Advar", 2, "Merchant", 30, 0, 150, 1, 0, 1);
            m48.XP = 40;
            m48.Gold = 25;
            m48.AddItemToDrop(item.Items[4], 60);

            Monster m54 = new Monster("Maering", 2, "Merchant", 30, 0, 150, 1, 0, 1);
            m54.XP = 40;
            m54.Gold = 25;
            m54.AddItemToDrop(item.Items[4], 60);

            Monster m55 = new Monster("Hans", 2, "Merchant", 30, 0, 150, 1, 0, 1);
            m55.XP = 40;
            m55.Gold = 25;
            m55.AddItemToDrop(item.Items[4], 60);

            Monster m56 = new Monster("Ongar", 2, "Merchant", 30, 0, 150, 1, 0, 1);
            m56.XP = 40;
            m56.Gold = 25;
            m56.AddItemToDrop(item.Items[4], 60);

            Monster m57 = new Monster("Itar", 2, "Merchant", 30, 0, 150, 1, 0, 1);
            m57.XP = 40;
            m57.Gold = 25;
            m57.AddItemToDrop(item.Items[4], 60);


            listMonsters.Add(m7);
            listMonsters.Add(m8);
            listMonsters.Add(m9);
            listMonsters.Add(m10);
            listMonsters.Add(m11);
            listMonsters.Add(m12);
            listMonsters.Add(m13);
            listMonsters.Add(m14);
            listMonsters.Add(m15);
            listMonsters.Add(m16);
            listMonsters.Add(m17);
            listMonsters.Add(m18);
            listMonsters.Add(m19);
            listMonsters.Add(m20);
            listMonsters.Add(m21);
            listMonsters.Add(m22);
            listMonsters.Add(m23);
            listMonsters.Add(m24);
            listMonsters.Add(m25);
            listMonsters.Add(m26);
            listMonsters.Add(m27);
            listMonsters.Add(m28);
            listMonsters.Add(m29);
            listMonsters.Add(m30);
            listMonsters.Add(m31);
            listMonsters.Add(m32);
            listMonsters.Add(m33);
            listMonsters.Add(m34);
            listMonsters.Add(m35);
            listMonsters.Add(m36);
            listMonsters.Add(m37);
            listMonsters.Add(m38);
            listMonsters.Add(m39);
            listMonsters.Add(m40);
            listMonsters.Add(m41);
            listMonsters.Add(m42);
            listMonsters.Add(m43);
            listMonsters.Add(m44);
            listMonsters.Add(m45);
            listMonsters.Add(m46);
            listMonsters.Add(m47);
            listMonsters.Add(m48);
            listMonsters.Add(m50);
            listMonsters.Add(m51);
            listMonsters.Add(m52);
            listMonsters.Add(m53);
            listMonsters.Add(m54);
            listMonsters.Add(m55);
            listMonsters.Add(m56);
            listMonsters.Add(m57);


            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/listMonsters.bin", FileMode.Create, FileAccess.Write,FileShare.None))
            {
                formatter.Serialize(stream, listMonsters);
            }
        }
    }
}
