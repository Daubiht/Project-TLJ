using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class Monster
    {
        readonly string _name;
        readonly string _race;

        int _level;
        int _physicalAttack;
        int _magicAttack;
        int _health;
        int _stamina;
        int _dodge;
        int _robustness;

        int _healthPoint;
        int _staminaPoint;
        int _maxHealthPoint;
        int _maxStaminaPoint;

        bool _frontPosition;
        bool _isAlive;

        readonly Dictionary<String, Skill> _skills;
        readonly Dictionary<Item, int> _drop;


        /// <summary>
        /// Create a new Monster who is level one.
        /// </summary>
        public Monster(string name, string race, int physicalAttack, int magicAttack, int health, int stamina, int robustness, int dodge)
        {
            _race = race;
            _name = name;
            _level = 1;
            _physicalAttack = physicalAttack;
            _magicAttack = magicAttack;
            _health = health;
            _stamina = stamina;
            _robustness = robustness;
            _dodge = dodge;

            _maxStaminaPoint = health;
            _maxHealthPoint = health;
            _staminaPoint = stamina;
            _healthPoint = stamina;

            _frontPosition = true;
            _isAlive = true;

            _skills = new Dictionary<string, Skill>();
            _drop = new Dictionary<Item, int>();
        }

        //==================================================
        //               Get some stuff
        //==================================================

        public int HealthPoint
        {
            get { return _healthPoint; }
        }

        public int StaminaPoint
        {
            get { return _staminaPoint; }
        }

        public string Name
        {
            get { return _name; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
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

        public int Robustness
        {
            get { return _robustness; }
        }

        public string Race
        {
            get { return _race; }
        }

        public Dictionary<string, Skill> Skills
        {
            get { return _skills; }
        }

        public int[] Stats
        {
            get { return new int[] { _physicalAttack, _magicAttack, _health, _robustness, _stamina, _dodge }; }
        }

        public int ChanceToDrop (Item item)
        {
            return _drop[item];
        }

        public bool IsThisSkill (Skill skill)
        {
            if (_skills.ContainsValue(skill)) return true;
            return false;
        }

        public bool Alive
        {
            get { return _isAlive; }
        }

        //======================================
        //           Treatement of data
        //======================================

        public Item AddItemToDrop (Item item, int chanceToDrop)
        {
            if (!_drop.ContainsKey(item))
            {
                _drop.Add(item, chanceToDrop);
            }
            else
            {
                return null;
            }

            return item;
        }

        public Skill AddSkill (string name, Skill skill)
        {
            int[] stat = skill.statRequired;

            if (stat == null || (stat[0] <= _physicalAttack && stat[1] <= _magicAttack && stat[2] <= _health && stat[3] <= _robustness && stat[4] <= _stamina && stat[5] <= _dodge))
            {
                if (skill.PreviousSkill != null)
                {
                    
                    if (_skills.ContainsKey(skill.PreviousSkill.Name))
                    {
                        _skills.Add(name, skill);
                        return skill;
                    }
                    else
                    {
                        return null;
                    }
                }
                else if (!_skills.ContainsValue(skill))
                {
                    _skills.Add(name, skill);
                    return skill;
                }
            }

            return null;
        }

        public int Hurt(int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentException();
            }

            _healthPoint -= damage;

            if (_healthPoint <= 0)
            {
                _healthPoint = 0;
                _isAlive = false;
            }
            return _healthPoint;
        }

        public void RemoveSkill (Skill skill)
        {
            _skills.Remove(skill.Name);
        }

        public bool FrontPosition
        {
            get { return _frontPosition; }
            set { _frontPosition = value; }
        }

        public bool UseSkill (Skill skill, Monster target)
        {
            if ((target == this && skill.Target == 0) || skill.Target == 1)
            {
                if (IsThisSkill(skill) && skill.Cost[0] <= _healthPoint && skill.Cost[1] <= _staminaPoint)
                {
                    if ((skill.Position == 0 && _frontPosition == true) || (skill.Position == 1 && _frontPosition == true) || (skill.Position == 2 && _frontPosition == false))
                    {
                        _healthPoint -= skill.Cost[0];
                        _staminaPoint -= skill.Cost[1];

                        return true;
                    }
                }
            }

            return false;
        }

        // This methods allows the monster to attack a member of the team
        public void Attack(Team teamToAttack)
        {
            // List to repertory every alive FRONT MEMBERS, list used by FRONT MONSTERS
            List<Character> listFrontFMembers = new List<Character>();
            // List to repertory every alive FRONT AND HIDDEN MEMBERS, list used by HIDDEN MONSTERS
            List<Character> listFrontHiddenMembers = new List<Character>();

            // Classify front or hidden members of the team
            foreach ( Character c in teamToAttack.Members)
            {
                // Classify alive front members, this list is used for monsters in front position
                if ( c.FrontPosition == true & c.isAlive == true ) listFrontFMembers.Add(c); 
                // Classify alive front + hidden members, this list is used for monsters in hidden position
                if ( c.isAlive == true ) listFrontHiddenMembers.Add(c);
            }
            // if the monster is alive he can attack
            if ( _isAlive )
            {
                // If the monster is in front position he can only attack front member
                if( _frontPosition == true )
                {
                    Random rdm = new Random();
                    // Generate a random index which represent the targetted member 
                    int indexRdmMember = rdm.Next(0, listFrontFMembers.Count - 1);
                    listFrontFMembers[indexRdmMember].Hurt(_physicalAttack);
                }
                // If the monster is in hidden position he can attack front or hidden members
                if ( _frontPosition == false )
                {
                    Random rdm = new Random();
                    // Generate a random index which represent the targetted member 
                    int indexRdmMember = rdm.Next(0, listFrontHiddenMembers.Count - 1);
                    listFrontHiddenMembers[indexRdmMember].Hurt(_physicalAttack);
                }
            }
        }
    }
}
