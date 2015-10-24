﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Inventory.FC;

namespace Inventory.Test
{
    [TestFixture]
    public class InventoryTest
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

            Invent invent = new Invent();
            invent.AddItem(itemtest, 2);

            Assert.AreEqual(true, invent.GetItem(itemtest));
        }

        [Test]
        public void Test_Inventory_RemoveItem()
        {
            Item itemtest = new Item("épée", 10, 120, "Epee standard", "arme");
            itemtest.AddRequired("attaque physique", 7);
            itemtest.AddStats("attaque physique", 5);

            Invent invent = new Invent();
            invent.AddItem(itemtest, 2);

            Assert.AreEqual(true, invent.GetItem(itemtest));
            Assert.AreEqual(1, invent.RemoveItem(itemtest));
        }

        [Test]
        public void Test_Inventory_AddGold()
        {
            Invent invent = new Invent();
            invent.AddGold(10);
            Assert.AreEqual(10, invent.GetGold);
        }

        [Test]
        public void Test_Inventory_RemoveGold()
        {
            Invent invent = new Invent();
            invent.AddGold(100);
            invent.RemoveGold(10);
            Assert.AreEqual(90, invent.GetGold);
        }

        [Test]
        public void Test_Upload_listitems()
        {
            ListItems listitems = new ListItems();

            List<Item> wantedList = new List<Item>();
            Item item1 = new Item("Dague en bois", 5, 1, "Petite dague en bois, peu efficace en combat mais tres belle ouvrage", "arme");

            item1.AddStats("attaque physique", 10);
            item1.AddRequired("attaque physique", 2);

            wantedList.Add(item1);

            Assert.AreEqual(item1.GetName, listitems.GetItems[0].GetName);
            Assert.AreEqual(item1.GetDescription, listitems.GetItems[0].GetDescription);
            Assert.AreEqual(item1.GetWeight, listitems.GetItems[0].GetWeight);
            Assert.AreEqual(item1.GetValue, listitems.GetItems[0].GetValue);
            Assert.AreEqual(item1.GetStats, listitems.GetItems[0].GetStats);
            Assert.AreEqual(item1.GetRequired, listitems.GetItems[0].GetRequired);
            Assert.AreEqual(item1.Type, listitems.GetItems[0].Type);
        }

        [Test]
        public void Test_Upload_listitems2()
        {
            ListItems listitems = new ListItems();

            List<Item> wantedList = new List<Item>();
            Item item2 = new Item("Bandage", 1, 5, "Bandage rudimentaire permettant d'arreter un saignement", "consommable");
            item2.AddStats("vie", 10);
            wantedList.Add(item2);

            Assert.AreEqual(item2.GetName, listitems.GetItems[1].GetName);
            Assert.AreEqual(item2.GetDescription, listitems.GetItems[1].GetDescription);
            Assert.AreEqual(item2.GetWeight, listitems.GetItems[1].GetWeight);
            Assert.AreEqual(item2.GetValue, listitems.GetItems[1].GetValue);
            Assert.AreEqual(item2.GetStats, listitems.GetItems[1].GetStats);
            Assert.AreEqual(item2.GetRequired, listitems.GetItems[1].GetRequired);
            Assert.AreEqual(item2.Type, listitems.GetItems[1].Type);
        }

        [Test]
        public void Test_Upload_listitems3()
        {
            ListItems listitems = new ListItems();
            List<Item> wantedList = new List<Item>();
            Item item3 = new Item("Collier en argent", 2, 120, "Collier en argent n'ayant aucune utilite autre que la beaute du metal", "bijoux");
            item3.AddRequired("attaque magique", 10);
            wantedList.Add(item3);

            Assert.AreEqual(item3.GetName, listitems.GetItems[2].GetName);
            Assert.AreEqual(item3.GetDescription, listitems.GetItems[2].GetDescription);
            Assert.AreEqual(item3.GetWeight, listitems.GetItems[2].GetWeight);
            Assert.AreEqual(item3.GetValue, listitems.GetItems[2].GetValue);
            Assert.AreEqual(item3.GetStats, listitems.GetItems[2].GetStats);
            Assert.AreEqual(item3.GetRequired, listitems.GetItems[2].GetRequired);
            Assert.AreEqual(item3.Type, listitems.GetItems[2].Type);
        }
    }
}
