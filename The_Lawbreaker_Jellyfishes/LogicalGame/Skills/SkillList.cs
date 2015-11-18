using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame
{
    [Serializable]
    public class SkillList
    {
        Dictionary<string, Skill> skillList;

        public SkillList ()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("../../../Ressources/skillList.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            skillList = (Dictionary<string, Skill>)formatter.Deserialize(stream);
            stream.Close();
        }

        public Skill Add (Skill skill)
        {
            if (skillList.ContainsValue(skill))
            {
                return null;
            }

            skillList.Add(skill.Name, skill);
            return skill;
        }

        public bool Remove(Skill skill)
        {
            if (!skillList.ContainsKey(skill.Name))
            {
                return false;
            }

            skillList.Remove(skill.Name);
            return true;
        }

        public Dictionary<string, Skill> ObtainList
        {
            get { return skillList; }
        }

        public void Serializ ()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("../../../Ressources/skillList.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, skillList);
            stream.Close();
        }
    }
}
