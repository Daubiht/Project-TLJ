using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LogicalGame.Test
{
    [TestFixture]
    public class CharacterTest
    {
        [Test]
        public void Create_a_new_perso_with_a_name_and_level_one()
        {
            Character p1 = new Character("George", "Dwarf", true);

            Assert.AreEqual("George", p1.Name);
            Assert.AreEqual(1, p1.Level);
        }

        [Test]
        public void A_perso_can_earn_xp_and_level_up()
        {
            Character p1 = new Character("George", "Dwarf", true);

            p1.EarnXp(25);
            Assert.AreEqual(p1.CurentXp, 25);

            p1.EarnXp(325);
            Assert.AreEqual(p1.CurentXp, 50);
            Assert.AreEqual(p1.Level, 4);
        }

        [Test]
        public void A_perso_can_have_skills()
        {
            Character p1 = new Character("George", "Dwarf", true);
            Skill s1 = new Skill("Attaque", null, 0, 1, null, new int[4]);

            p1.AddSkill("Attaque", s1);

            Assert.AreEqual(p1.Skills[s1.Name], s1);
            Assert.IsTrue(p1.Skills.ContainsValue(s1));
        }

        [Test]
        public void A_perso_can_increase_his_stats()
        {
            Character p1 = new Character("George", "Dwarf", true);

            p1.EarnXp(00);

            Assert.AreEqual(p1.StatsUp(1,0,0,0,0,0)[0], 11);
            Assert.AreEqual(p1.IncreasePA(), 12);
            Assert.AreEqual(p1.IncreasePA(), 13);
            Assert.AreEqual(p1.IncreasePA(), 14);
            Assert.AreEqual(p1.IncreasePA(), 15);
            Assert.AreEqual(p1.IncreasePA(), 16);
            Assert.AreEqual(p1.IncreasePA(), 17);
            Assert.AreEqual(p1.IncreasePA(), 18);
            Assert.AreEqual(p1.IncreasePA(), 19);
            Assert.AreEqual(p1.IncreasePA(), 20);
            Assert.AreEqual(p1.IncreasePA(), 20);

        }

        [Test]
        public void A_Character_can_use_consumable_and_that_make_the_good_effect()
        {
            Character p1 = new Character("George", "Dwarf", true);
            Item i1 = new Item("Potion de soin légers", 1, 10,  "Soigne légerement", "consumable");
            i1.AddStats("heal", 25);
            Item i2 = new Item("Potion de resurection", 1, 1000, "Redonne la vie à une personnage allié malheureusement décédé", "consumable");
            i2.AddStats("regainStamina", 25);
            Item i3 = new Item("Potion de Vigueur", 1, 10, "Enleve legerement la fatigue des combats", "consumable");
            i3.AddStats("resurection", 0);
            Skill s1 = new Skill("test", null, 0, 0, null, new int[] { 0, 50 });

            Assert.AreEqual(s1, p1.AddSkill(s1.Name, s1));

           
            p1.Hurt(50);
            Assert.AreEqual(50, p1.HealthPoint);
            p1.UseConsumable(i1);
            Assert.AreEqual(75, p1.HealthPoint);

            p1.isAlive = false;
            p1.UseConsumable(i3);
            Assert.IsTrue(p1.isAlive);

            p1.UseSkill(s1, p1);
            Assert.AreEqual(50, p1.StaminaPoint);
            p1.UseConsumable(i2);
            Assert.AreEqual(75, p1.StaminaPoint);

        }
    }
}
