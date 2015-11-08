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
            Skill s1 = new Skill("slash", null, 0, 0, null, new int[] { 0, 10 });
            Skill s2 = new Skill("super slash", new int[] { 15, 0, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            s2.PreviousSkill = s1;
            Skill s3 = new Skill("fire slash", new int[] { 15, 0, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            s3.PreviousSkill = s1;
            Skill s4 = new Skill("energy ball", null, 0, 0, null, new int[] { 0, 10 });
            Skill s5 = new Skill("fire ball", new int[] { 0, 15, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            s5.PreviousSkill = s4;
            Skill s6 = new Skill("ice ball", new int[] { 0, 15, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            s6.PreviousSkill = s5;
            Skill s7 = new Skill("mega super slash", new int[] { 40, 0, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            s7.PreviousSkill = s2;


            Character p = new Character("lol", "Dwarf", true);

            Dictionary<string, Skill> skillList = new Dictionary<string, Skill>();
            skillList.Add(s1.Name, s1);
            skillList.Add(s2.Name, s2);
            skillList.Add(s3.Name, s3);
            skillList.Add(s4.Name, s4);
            skillList.Add(s5.Name, s5);
            skillList.Add(s6.Name, s6);
            skillList.Add(s7.Name, s7);

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/skillList.bin", FileMode.Create, FileAccess.Write,FileShare.None))
            {
                formatter.Serialize(stream, skillList);
            }
        }
    }
}
