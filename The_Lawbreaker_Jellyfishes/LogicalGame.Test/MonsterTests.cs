using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using LogicalGame;

namespace LogicalGame.Test
{
    [TestFixture]
    public class MonsterTests
    {
        [Test]
        public void Create_a_new_Monster_with_a_name()
        {
            Monster m1 = new Monster("George", "Dwarf", 150, 10, 500, 100, 100, 20);

            Assert.AreEqual("George", m1.Name);
            Assert.AreEqual("Dwarf" , m1.Race);
            Assert.AreEqual(150, m1.PhysicalAttack);
            Assert.AreEqual(10, m1.MagicAttack);
            Assert.AreEqual(20, m1.Dodge);
            Assert.AreEqual(100, m1.Robustness);
            Assert.AreEqual(500, m1.Health);
            Assert.AreEqual(100, m1.Stamina);
        }

        [Test]
        public void A_Monster_can_have_skills()
        {
            Monster m1 = new Monster("George", "Dwarf", 150, 10, 500, 100, 100, 20);

            Skill s1 = new Skill("Attaque", null, 0, 1, null, new int[4]);

            m1.AddSkill("Attaque", s1);

            Assert.AreEqual(m1.Skills[s1.Name], s1);
            Assert.IsTrue(m1.Skills.ContainsValue(s1));
        }

        [Test]
        public void A_Monster_can_have_Item_to_drop()
        {
            Monster m1 = new Monster("George", "Dwarf", 150, 10, 500, 100, 100, 20);

            Item item1 = new Item("Epée", 10, 10, "C'est une épée quoi...", "arme");
            Item item2 = new Item("Epée", 10, 10, "C'est une épée quoi...", "arme");
            Item item3 = new Item("Epée", 10, 10, "C'est une épée quoi...", "arme");

            m1.AddItemToDrop(item1, 50);
            m1.AddItemToDrop(item2, 10);
            m1.AddItemToDrop(item3, 2);

            Assert.AreEqual(m1.ChanceToDrop(item1), 50);
            Assert.AreEqual(m1.ChanceToDrop(item2), 10);
            Assert.AreEqual(m1.ChanceToDrop(item3), 2);
        }
    }
}