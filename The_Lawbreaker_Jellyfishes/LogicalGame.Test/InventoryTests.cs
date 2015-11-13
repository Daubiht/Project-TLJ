using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using NUnit.Framework;

namespace LogicalGame.Test
{
    [TestFixture]
    public class InventoryTests
    {
        [Test]
        public void Test_Create_Item()
        {
            Item itemtest = new Item("épée", 10, 120, "Epee standard", "arme");

            itemtest.AddRequired("attaque physique", 7);
            itemtest.AddStats("attaque physique", 5);

            Dictionary<string, int> stat = new Dictionary<string, int>();
            stat.Add("attaque physique", 5);

            Dictionary<string, int> required = new Dictionary<string, int>();
            required.Add("attaque physique", 7);

            Assert.AreEqual("épée", itemtest.GetName);
            Assert.AreEqual(120, itemtest.GetValue);
            Assert.AreEqual(10, itemtest.GetWeight);
            Assert.AreEqual("Epee standard", itemtest.GetDescription);
            Assert.AreEqual(stat, itemtest.GetStats);
            Assert.AreEqual(required, itemtest.GetRequired);
        }

        [Test]
        public void Test_Inventory_AddItem()
        {
            Item itemtest = new Item("épée", 10, 120, "Epee standard", "arme");
            itemtest.AddRequired("attaque physique", 7);
            itemtest.AddStats("attaque physique", 5);

            Invent invent = new Invent(null);
            invent.AddItem(itemtest, 2);

            Assert.AreEqual(true, invent.GetItem(itemtest));
        }

        [Test]
        public void Test_Inventory_RemoveItem()
        {
            Item itemtest = new Item("épée", 10, 120, "Epee standard", "arme");
            itemtest.AddRequired("attaque physique", 7);
            itemtest.AddStats("attaque physique", 5);

            Invent invent = new Invent(null);
            invent.AddItem(itemtest, 2);

            Assert.AreEqual(true, invent.GetItem(itemtest));
            Assert.AreEqual(1, invent.RemoveItem(itemtest));
        }

        [Test]
        public void Test_Inventory_AddGold()
        {
            Invent invent = new Invent(null);
            invent.AddGold(10);
            Assert.AreEqual(10, invent.GetGold);
        }

        [Test]
        public void Test_Inventory_RemoveGold()
        {
            Invent invent = new Invent(null);
            invent.AddGold(100);
            invent.RemoveGold(10);
            Assert.AreEqual(90, invent.GetGold);
        }

        [Test]
        public void Test_Upload_listitems()
        {
            CreateItems c = new CreateItems();
            ListItems listitems = new ListItems();

            List<Item> wantedList = new List<Item>();
            Item item1 = new Item("Dague en bois", 5, 1, "Petite dague en bois, peu efficace en combat mais tres belle ouvrage", "arme");

            item1.AddStats("attaque physique", 5);
            item1.AddStats("esquive", 2);

            wantedList.Add(item1);

            Assert.AreEqual(item1.GetName, listitems.Items[0].GetName);
            Assert.AreEqual(item1.GetDescription, listitems.Items[0].GetDescription);
            Assert.AreEqual(item1.GetWeight, listitems.Items[0].GetWeight);
            Assert.AreEqual(item1.GetValue, listitems.Items[0].GetValue);
            Assert.AreEqual(item1.GetStats, listitems.Items[0].GetStats);
            Assert.AreEqual(item1.GetRequired, listitems.Items[0].GetRequired);
            Assert.AreEqual(item1.Type, listitems.Items[0].Type);
        }

        [Test]
        public void Test_Upload_listitems2()
        {
            CreateItems c = new CreateItems();
            ListItems listitems = new ListItems();

            List<Item> wantedList = new List<Item>();
            Item item2 = new Item("Bandage", 1, 5, "Bandage rudimentaire permettant d'arreter un saignement", "consommable");
            item2.AddStats("vie", 10);
            wantedList.Add(item2);

            Assert.AreEqual(item2.GetName, listitems.Items[1].GetName);
            Assert.AreEqual(item2.GetDescription, listitems.Items[1].GetDescription);
            Assert.AreEqual(item2.GetWeight, listitems.Items[1].GetWeight);
            Assert.AreEqual(item2.GetValue, listitems.Items[1].GetValue);
            Assert.AreEqual(item2.GetStats, listitems.Items[1].GetStats);
            Assert.AreEqual(item2.GetRequired, listitems.Items[1].GetRequired);
            Assert.AreEqual(item2.Type, listitems.Items[1].Type);
        }

        [Test]
        public void Test_Upload_listitems3()
        {
            CreateItems c = new CreateItems();
            ListItems listitems = new ListItems();
            List<Item> wantedList = new List<Item>();
            Item item3 = new Item("Collier en argent", 2, 120, "Collier en argent emettant une étrange lueur", "bijoux");
            item3.AddRequired("attaque magique", 10);
            wantedList.Add(item3);

            Assert.AreEqual(item3.GetName, listitems.Items[2].GetName);
            Assert.AreEqual(item3.GetDescription, listitems.Items[2].GetDescription);
            Assert.AreEqual(item3.GetWeight, listitems.Items[2].GetWeight);
            Assert.AreEqual(item3.GetValue, listitems.Items[2].GetValue);
            Assert.AreEqual(item3.GetStats, listitems.Items[2].GetStats);
            Assert.AreEqual(item3.GetRequired, listitems.Items[2].GetRequired);
            Assert.AreEqual(item3.Type, listitems.Items[2].Type);
        }

        [Test]
        public void Test_add_items_in_plopi_game()
        {
            IFormatter formatter = new BinaryFormatter();
            MapWorld w;
            using (Stream stream = new FileStream("../../../Ressources/world.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                w = (MapWorld)formatter.Deserialize(stream);
            }

            for (int i = 0; i < 38; i++)
            {
                Item item = new Item("Plop"+i, 2, 100, "testdefolie", "typetest");
                w.Team.Invent.AddItem(item, 1);
            }

            ListItems l = new ListItems();
            w.Team.Invent.AddItem(l.Items[0], 1);

            Assert.IsNotEmpty(w.Team.Invent.Inventory);

            Character MainC1 = new Character("Plopi", "dwarf", true);
            MainC1.IsMain = true;
            w.Team.AddMembers(MainC1);
            w.Save(1);
        }
    }
}
