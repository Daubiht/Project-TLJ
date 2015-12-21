using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class Monster
    {
        readonly string _name;
        readonly string _race;

        // Stats
        int _level;
        int _physicalAttack;
        int _magicAttack;
        int _health;
        int _stamina;
        int _dodge;
        int _robustness;

        // Health and Stamina
        int _healthPoint;
        int _staminaPoint;
        int _maxHealthPoint;
        int _maxStaminaPoint;

        // Drop
        int _gold;
        int _xp;

        // Fight
        bool _frontPosition;
        bool _isAlive;
        List<Effect> _effects;

        readonly Dictionary<String, Skill> _skills;
        Dictionary<Item, int> _drop;


        /// <summary>
        /// Create a new Monster who is level one.
        /// </summary>
        public Monster(string name, int level,string race, int physicalAttack, int magicAttack, int health, int stamina, int robustness, int dodge)
        {
            _race = race;
            _name = name;
            _level = level;
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
            _effects = new List<Effect>();

            _skills = new Dictionary<string, Skill>();
            _drop = new Dictionary<Item, int>();
            _gold = 0;
        }

        //==================================================
        //               Get some stuff
        //==================================================

        public List<Effect> Effect
        {
            get { return _effects; }
        }

        public Dictionary<Item, int> Drop
        {
            get { return _drop; }
            set { _drop = value; }
        }

        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }

        public int HealthPoint
        {
            get { return _healthPoint; }
            set { _healthPoint = value; }
        }

        public void Heal (int value)
        {
            _healthPoint += value;
            if (_healthPoint > _maxHealthPoint) _healthPoint = _maxHealthPoint;
        }

        public int StaminaPoint
        {
            get { return _staminaPoint; }
            set { _staminaPoint = value; }
        }

        public int XP
        {
            get { return _xp; }
            set { _xp = value; }
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

        public int MaxHealthPoint
        {
            get { return _maxHealthPoint; }
            set { _maxHealthPoint = value; }
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
        // Method to remove HP of the monster because of a launched attack by a character
        public int Hurt(int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentException();
            }

            // Chance to dodge the the attack
            Random r = new Random();
            // Random between 0 and 100
            int chanceToDodge = r.Next(0, 101);
            // if chanceToDodge is equal to dodge / 2, the monster dodges the attack of the character
            if ( chanceToDodge <= Dodge/2 )
                damage = 0;

            // The damage launched on the monster is reduced thanks to the monster's robustness
            damage = damage - (int)Math.Ceiling(Robustness / 100.0 * damage); // Math.Ceiling around to the superior bound, 0.3 become 1.0
            // If damage is under 0 because the monster has too much robustness, it will give healt point to the monster because of a bug, so we set the value to 5
            if ( damage < 5 ) damage = 5;
            // Remove HP
            _health -= damage;

            if (_health <= 0)
            {
                _health = 0;
                _isAlive = false;
            }
            return _health;
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

        /// <summary>
        /// Use to apply the effects in the time.
        /// </summary>
        public void ApplyEffect()
        {
            if (_isAlive)
            {
                for(int i = 0; i < _effects.Count; i++)
                {
                    Effect effect = _effects[i];
                    int power = effect.Power;
                    string name = effect.Name;
                    Character caster = effect.Caster;

                    if (effect.Time > 0)
                    {
                        switch (name)
                        {
                            case "brulure":
                                Hurt((int)Math.Round((decimal)(power/100 * caster.MagicAttack)));
                                break;
                            case "saignement":
                                Hurt((int)Math.Round((decimal)(power / 100 * caster.PhysicalAttack)));
                                break;
                        }

                        effect.Time--;
                        if (effect.Time <= 0)
                        {
                            _effects.Remove(effect);
                        }
                    }
                }
            }
        }

        // This methods allows the monster to attack a member of the team
        public void Attack(Team teamToAttack)
        {
            // List to repertory every ALIVE FRONT MEMBERS
            List<Character> listFrontMembers = new List<Character>();
            // List to repertory every ALIVE FRONT AND HIDDEN MEMBERS
            List<Character> listFrontHiddenMembers = new List<Character>();

            // Classify front or hidden members of the team
            foreach ( Character c in teamToAttack.Members)
            {
                // Classify alive front members
                if ( c.FrontPosition == true & c.isAlive == true ) listFrontMembers.Add(c); 
                // Classify alive front + hidden members
                else if ( c.isAlive == true ) listFrontHiddenMembers.Add(c);
            }
            

            // If all FRONT MEMBERS ARE DEAD, every HIDDEN MEMBERS will be in FRONT POSITION
            if ( listFrontMembers.Count == 0 )
            {
                foreach (Character ch in listFrontHiddenMembers)
                {
                    ch.FrontPosition = true;
                    listFrontMembers.Add(ch);
                }
            }
            // if the monster is alive he can attack
            if ( _isAlive )
            {
                Random rdm = new Random();
                // Generate a random index which represent the targetted member in FRONT POSITION
                int indexRdmMember = rdm.Next(0, listFrontMembers.Count);
                listFrontMembers[indexRdmMember].Hurt(_physicalAttack);
            }
           
        }
    }
}
