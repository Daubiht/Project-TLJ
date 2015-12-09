using NUnit.Framework;

namespace LogicalGame.Test
{
    [TestFixture]
    public class SkillsTest
    {
        [Test]
        public void We_can_creat_a_skill_and_add_it_to_a_character ()
        {
            Skill coolSlash = new Skill("cool slash", "Attaque", null, 1, 1, null, null); ;
            Skill superSlash = new Skill("Super Slash", "Attaque", null, 1, 1, null, null); ;
            Skill slash = new Skill("slash", "Attaque", null,1,1,null,null);

            Character p = new Character("lol", "Dwarf", true);

            Assert.AreEqual( slash, p.AddSkill(slash.Name, slash));
            Assert.AreEqual(null, p.AddSkill(slash.Name, slash));
            Assert.AreEqual(superSlash, p.AddSkill(superSlash.Name, superSlash));

        }

        [Test]
        public void We_can_use_a_skill_if_the_position_is_good()
        {
            Skill slash = new Skill("slash", "Attaque", null, 1, 1, null, new int[] { 0, 10 });

            Character p = new Character("lol", "Dwarf", true);

            Assert.AreEqual(slash, p.AddSkill(slash.Name, slash));

            Assert.AreEqual(true, p.UseSkill(slash, p));
            p.FrontPosition = false;
            Assert.AreEqual(false, p.UseSkill(slash, p));
        }

        [Test]
        public void We_can_learn_a_skill_with_the_good_stats()
        {
            Skill slash = new Skill("slash", "Attaque", new int[] { 15, 0, 0, 0, 0, 0 }, 1, 1, null, new int[] { 0, 10 });

            Character p = new Character("lol", "Dwarf", true);

            Assert.AreEqual(null, p.AddSkill(slash.Name, slash));
            p.StatsUp(10, 0, 0, 0, 0, 0);
            Assert.AreEqual(slash, p.AddSkill(slash.Name, slash));
        }

        [Test]
        public void We_can_use_a_skill_if_we_have_enougth_stamina_or_health()
        {
            Skill slash = new Skill("slash", "Attaque", null, 1, 0, null, new int[] { 0, 10 });

            Character p = new Character("lol", "Dwarf", true);

            int stamina = p.StaminaPoint;

            Assert.AreEqual(slash, p.AddSkill(slash.Name, slash));

            Assert.AreEqual(true, p.UseSkill(slash, p));
            Assert.AreEqual(stamina-10, p.StaminaPoint);
            Assert.AreEqual(true, p.UseSkill(slash, p));
            Assert.AreEqual(true, p.UseSkill(slash, p));
            Assert.AreEqual(true, p.UseSkill(slash, p));
            Assert.AreEqual(true, p.UseSkill(slash, p));
            Assert.AreEqual(true, p.UseSkill(slash, p));
            Assert.AreEqual(true, p.UseSkill(slash, p));
            Assert.AreEqual(true, p.UseSkill(slash, p));
            Assert.AreEqual(true, p.UseSkill(slash, p));
            Assert.AreEqual(true, p.UseSkill(slash, p));
            Assert.AreEqual(false, p.UseSkill(slash, p));
        }

        [Test]
        public void We_can_use_a_skill_with_the_good_target()
        { 
            Skill s1 = new Skill("slash1", "Attaque", null, 0, 0, null, new int[] { 0, 10 });
            Skill s2 = new Skill("slash2", "Attaque", null, 1, 0, null, new int[] { 0, 10 });
            Skill s3 = new Skill("slash3", "Attaque", null, 2, 0, null, new int[] { 0, 10 });

            Character p = new Character("lol", "Dwarf", true);

            int stamina = p.StaminaPoint;

            Assert.AreEqual(s1, p.AddSkill(s1.Name, s1));
            Assert.AreEqual(s2, p.AddSkill(s2.Name, s2));
            Assert.AreEqual(s3, p.AddSkill(s3.Name, s3));

            Assert.AreEqual(true, p.UseSkill(s1, p));
            Assert.AreEqual(true, p.UseSkill(s2, p));
            Assert.AreEqual(false, p.UseSkill(s3, p));
            
        }

        //[Test]
        public void We_can_use_skill_and_that_make_things()
        {
            Skill s1 = new Skill("s4", "Attaque", null, 0, 0, null, new int[] { 0, 10 });

            Character p = new Character("lol", "Dwarf", true);

            SkillList sl = new SkillList();

         
        }
    }
}

