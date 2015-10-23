using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.TLJ.perso
{
    public class Perso
    {
        readonly string _name;
        readonly string _race;
        int _level;
        int _physicalAttack;
        int _magicAttack;
        int _health;
        int _stamina;
        int _dodge;

        int _nextLevel;
        int _currentXp;
        int _skillPoint;
        int _statsPoint;
        
        Dictionary<String, Skill> _skills;


        /// <summary>
        /// Create a new character who is level one.
        /// </summary>
        /// <param name="name">The name of the character</param>
        /// /// <param race="race">The race of the character (Dwarf, Giant, Human, etc.</param>
        public Perso(string name, string race)
        {
            _race = race;
            _name = name;
            _level = 1;
            _physicalAttack = 10;
            _magicAttack = 10;
            _health = 10;
            _stamina = 10;
            _dodge = 10;
            _nextLevel = 100;
            _currentXp = 0;
            _statsPoint = 10;
            _skillPoint = 1;

            _skills = new Dictionary<string, Skill>();
        }
        
        //==================================================
        //               Get some stuff
        //==================================================
        public string Name
        {
            get { return _name; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int LevelUp()
        {
            _level += 1;
            _statsPoint += 10;
            _skillPoint++;
            return _level;
        }

        public int PhysicalAttack
        {
            get { return _physicalAttack; }
        }

        public int MagicAttack
        {
            get { return _magicAttack; }
        }

        public int Dodge
        {
            get { return _dodge; }
        }

        public int Stamina
        {
            get { return _stamina; }
        }

        public int Health
        {
            get { return _health; }
        }

        public int CurentXp
        {
            get { return _currentXp; }
        }

        public string Race
        {
            get { return _race; }
        }

        public Dictionary<string, Skill> Skills
        {
            get { return _skills; }
        }

        public int NextLevel
        {
            get { return _nextLevel; }
        }

        //======================================
        //           Treatement of data
        //======================================

        public void EarnXp (int xp)
        {
            while (xp > _nextLevel)
            {
                xp -= _nextLevel;
                _level++;
                _skillPoint += 1;
                _statsPoint += 5;
            }
            _currentXp += xp;

        }

        public Skill AddSkill (string name, Skill skill)
        {
            _skills.Add(name, skill);
            return skill;
        }

        public void RemoveSkill (Skill skill)
        {
            _skills.Remove(skill.Name);
        }

        public int IncreasePA()
        {
            if (_statsPoint > 0)
            {
                _physicalAttack++;
                _statsPoint--;
            }

            return _physicalAttack;
        }

        public int IncreaseDodge()
        {
            if (_statsPoint > 0)
            {
                _dodge++;
                _statsPoint--;
            }

            return _dodge;
        }
        public int IncreaseMA()
        {
            if (_statsPoint > 0)
            {
                _statsPoint--;
                _magicAttack++;
            }

            return _magicAttack;
        }
        public int IncreaseStamina()
        {
            if (_statsPoint > 0)
            {
                _statsPoint--;
                _stamina++;
            }

            return _stamina;
        }
        public int IncreaseHealth()
        {
            if (_statsPoint > 0)
            {
                _statsPoint--;
                _health++;
            }

            return _health;
        }
    }
}
