using NUnit.Framework;
using System;

namespace LogicalGame.Test
{
    [TestFixture]
    public class CharacterTest
    {
        [Test]
        public void Try_get_list_stats_all_stuff()
        {
            Taverne tav = new Taverne();
            Character c = tav.New(1, 100, null);
            ListItems listi = new ListItems();
            Item i = listi.Items[0];
            Team t = new Team("test");
            c.InTeam = t;
            t.Invent.AddItem(i, 1);

            if (c.WearItem(i, i.Type))
            {
                foreach (string key in c.StatsStuff.Keys)
                {
                    Console.WriteLine(key + c.StatsStuff[key]);
                }
            }
        }

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
            p1.LevelUp(1);
            Skill s1 = new Skill("Attaque", "", null, 0, 1, null, new int[4]);

            p1.AddSkill("Attaque", s1);

            Assert.AreEqual(p1.Skills[s1.Name], s1);
            Assert.IsTrue(p1.Skills.ContainsValue(s1));
        }

        [Test]
        public void A_perso_can_increase_his_stats()
        {
            Character p1 = new Character("George", "Dwarf", true);

            p1.EarnXp(00);

            Assert.AreEqual(p1.StatsUp(1,0,0,0,0,0)[0], 6);
            Assert.AreEqual(p1.IncreasePA(), 7);
            Assert.AreEqual(p1.IncreasePA(), 8);
            Assert.AreEqual(p1.IncreasePA(), 9);
            Assert.AreEqual(p1.IncreasePA(), 10);
            Assert.AreEqual(p1.IncreasePA(), 11);
            Assert.AreEqual(p1.IncreasePA(), 12);
            Assert.AreEqual(p1.IncreasePA(), 13);
            Assert.AreEqual(p1.IncreasePA(), 14);
            Assert.AreEqual(p1.IncreasePA(), 15);
            Assert.AreEqual(p1.IncreasePA(), 15);

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
            Skill s1 = new Skill("test", "Attaque", null, 0, 0, null, new int[] { 0, 50 });

            Assert.AreEqual(s1, p1.AddSkill(s1.Name, s1));

            int health = p1.HealthPoint;

            p1.HealthPoint = 50;
            Assert.AreEqual(health - 50, p1.HealthPoint);
            p1.UseConsumable(i1);
            Assert.AreEqual(health - 50 + 25, p1.HealthPoint);

            p1.isAlive = false;
            p1.UseConsumable(i3);
            Assert.IsTrue(p1.isAlive);

            int stamina = p1.StaminaPoint;

            p1.UseSkill(s1, p1);
            Assert.AreEqual(stamina - 50, p1.StaminaPoint);
            p1.UseConsumable(i2);
            Assert.AreEqual(stamina - 50 + 25, p1.StaminaPoint);

        }
    }
}
