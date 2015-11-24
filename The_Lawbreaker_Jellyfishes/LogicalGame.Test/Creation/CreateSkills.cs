using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame.Test.Creation
{
    [TestFixture]
    public class CreateSkills
    {
        [Test]
        public void We_can_add_a_skill_in_the_file_of_skill_and_recup_a_list_of_skill()
        {
            //Physical Attack
            Skill sp1 = new Skill("slash", new int[] { 5, 0, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            Skill sp2 = new Skill("super slash", new int[] { 15, 0, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            sp2.PreviousSkill = sp1;
            Skill sp3 = new Skill("fire slash", new int[] { 15, 0, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            sp3.PreviousSkill = sp1;
            Skill sp4 = new Skill("mega super slash", new int[] { 40, 0, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            sp4.PreviousSkill = sp2;

            //Magic Attack
            Skill sm1 = new Skill("energy ball", new int[] { 0, 5, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            Skill sm2 = new Skill("fire ball", new int[] { 0, 15, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            sm2.PreviousSkill = sm1;
            Skill sm3 = new Skill("ice ball", new int[] { 0, 15, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            sm3.PreviousSkill = sm1;
            

            //Robustness
            Skill sr1 = new Skill("Position défensive", new int[] { 0, 0, 0, -1, 0, 0 }, 0, 0, null, new int[] { 0, 10 });

            //Health
            Skill sh1 = new Skill("Vitalité", new int[] { 0, 0, 5, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });

            //Dodge
            Skill sd1 = new Skill("Instinct", new int[] { 0, 0, 0, 0, 0, 5 }, 0, 0, null, new int[] { 0, 10 });

            //Stamina
            Skill ss1 = new Skill("Infatigable", new int[] { 0, 0, 0, 0, 5, 0 }, 0, 0, null, new int[] { 0, 10 });


            Character p = new Character("lol", "Dwarf", true);

            Dictionary<string, Skill> skillList = new Dictionary<string, Skill>();

            //Physical
            skillList.Add(sp1.Name, sp1);
            skillList.Add(sp2.Name, sp2);
            skillList.Add(sp3.Name, sp3);
            skillList.Add(sp4.Name, sp4);
            //Magic
            skillList.Add(sm1.Name, sm1);
            skillList.Add(sm2.Name, sm2);
            skillList.Add(sm3.Name, sm3);
            //Robustness
            skillList.Add(sr1.Name, sr1);
            //Stamina
            skillList.Add(ss1.Name, ss1);
            //Health
            skillList.Add(sh1.Name, sh1);
            //Dodge
            skillList.Add(sd1.Name, sd1);




            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/skillList.bin", FileMode.Create, FileAccess.Write,FileShare.None))
            {
                formatter.Serialize(stream, skillList);
            }
        }
    }
}
