using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LogicalGame
{
    public class RandomCharacter
    {
        public RandomCharacter ()
        {

        }

        // Return a random character with a level between two values
        public Character New (int levelMin, int levelMax)
        {
            string path;
            string[] nameList;
            string race;
            int stat;
            int statsPoint;
            bool isFemale = false;
            int statValue;
            string[] races = new string[] { "Dwarf", "Elves", "Human", "Giant" };
            Character perso;
            Random ran = new Random();
            int[] statUped = new int[6];
            string name;

            // Random sexe
            if (ran.Next(0, 2) == 0)
            {
                isFemale = true;
            }

            // Random name
            if (isFemale == true)
            {
                path = "../../../Ressources/nameListF.txt";

                if (!File.Exists(path) || new FileInfo(path).Length == 0)
                {
                    nameList = new string[] { "Herial", "Ele", "Elyë", "Turiel", "Numaliel", "Valiel" };
                    name = nameList[ran.Next(0, nameList.Count())];
                }
                else
                {
                    nameList = File.ReadAllLines(path);
                    name = nameList[ran.Next(0, nameList.Count())];
                }
            }
            else
            {
                path = "../../../Ressources/nameListM.txt";

                if (!File.Exists(path) || new FileInfo(path).Length == 0)
                {
                    nameList = new string[] { "Hartmod", "Thorgis", "Veland", "Thorolf", "Hagbard", "Bjarnulf" };
                    name = nameList[ran.Next(0, nameList.Count())];
                }
                else
                {
                    nameList = File.ReadAllLines(path);
                    name = nameList[ran.Next(0, nameList.Count())];
                }
            }

            

            // Random race
            race = races[ran.Next(0, races.Count())];

            perso = new Character(name, race, isFemale);

            // Random level
            perso.LevelUp(ran.Next(levelMin, levelMax));

            //Random stats
            

            for (int i = 0 ; i < 6 ; i++)
            {
                do
                {
                    stat = ran.Next(0, 6);                    
                } while (statUped.Contains(stat) && i != 5);

                statsPoint = perso.StatsPoint;
                statUped[i] = stat;
                if (i == 5)
                {
                    statValue = statsPoint;
                }
                else
                {
                    statValue = ran.Next(0, statsPoint);
                }

                switch (stat)
                {
                    case 0:
                        perso.StatsUp(statValue, 0, 0, 0, 0, 0);
                        break;
                    case 1:
                        perso.StatsUp(0, statValue, 0, 0, 0, 0);
                        break;
                    case 2:
                        perso.StatsUp(0, 0, statValue, 0, 0, 0);
                        break;
                    case 3:
                        perso.StatsUp(0, 0, 0, statValue, 0, 0);
                        break;
                    case 4:
                        perso.StatsUp(0, 0, 0, 0, statValue, 0);
                        break;
                    case 5:
                        perso.StatsUp(0, 0, 0, 0, 0, statValue);
                        break;
                }
            }

            //Random Skills
            SkillList sl = new SkillList();
            List<Skill> st = new List<Skill>();
            Skill s;
            foreach (Skill skill in sl.ObtainList.Values)
            {
                bool learnable = true;
                if (skill.statRequired != null)
                {
                    for (int i = 0; i < skill.statRequired.Count(); i++)
                    {
                        if (skill.statRequired[i] > perso.Stats[i])
                        {
                            learnable = false;
                        }
                    }
                }

                if (learnable == true)
                {
                    st.Add(skill);
                }

            }
            while (perso.SkillPoint > 0 && st.Count > 0)
            {
                int rannbr = ran.Next(0, st.Count);
                s = st[rannbr];
                if (s != null)
                { 
                    while (perso.AddSkill(s.Name, s) == null)
                    {
                        s = s.PreviousSkill;
                    }

                    st.Remove(s);
                }
            }

            return perso;
        }
    }
}
