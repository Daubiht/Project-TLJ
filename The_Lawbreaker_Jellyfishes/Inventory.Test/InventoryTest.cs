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
            Item itemtest = new Item("épée", 10, 120, "Epee standard");

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
            Item itemtest = new Item("épée", 10, 120, "Epee standard");
            itemtest.AddRequired("attaque physique", 7);
            itemtest.AddStats("attaque physique", 5);

            Invent invent = new Invent();
            invent.AddItem(itemtest, 2);

            Assert.AreEqual(true, invent.GetItem(itemtest));
        }

        [Test]
        public void Test_Inventory_RemoveItem()
        {
            Item itemtest = new Item("épée", 10, 120, "Epee standard");
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
    }
}