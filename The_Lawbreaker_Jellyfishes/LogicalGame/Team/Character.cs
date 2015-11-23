using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class Character
    {
        Team _team;

        readonly string _name;
        readonly string _race;
        readonly bool _isFemale;

        int _level;
        int _physicalAttack;
        int _magicAttack;
        int _health;
        int _stamina;
        int _dodge;
        int _robustness;

        int _nextLevel;
        int _currentXp;
        int _skillPoint;
        int _statsPoint;

        int _healthPoint;
        int _staminaPoint;
        int _maxHealthPoint;
        int _maxStaminaPoint;

        bool _frontPosition;
        bool _isAlive;
        bool _isMain;

        readonly Dictionary<String, Skill> _skills;
        readonly Dictionary<string, Item> _stuffs;


        /// <summary>
        /// Create a new character who is level one.
        /// </summary>
        /// <param name="name">The name of the character</param>
        /// <param race="race">The race of the character (Dwarf, Giant, Human, etc.</param>
        public Character(string name, string race, bool isFemale)
        {
            _isAlive = true;
            _isFemale = isFemale;
            _race = race;
            _name = name;
            _level = 1;
            _physicalAttack = 10;
            _magicAttack = 10;
            _health = 10;
            _stamina = 10;
            _robustness = 10;
            _dodge = 10;
            _nextLevel = 100;
            _currentXp = 0;
            _statsPoint = 10;
            _skillPoint = 1;

            _maxStaminaPoint = 100;
            _maxHealthPoint = 100;
            _staminaPoint = 100;
            _healthPoint = 100;

            _frontPosition = true;

            _skills = new Dictionary<string, Skill>();
            _stuffs = new Dictionary<string, Item>();
        }

        //==================================================
        //               Get some stuff
        //==================================================
        public Dictionary<string, Item> Stuffs
        {
            get { return _stuffs; }
        }
        public Team InTeam
        {
            get {return _team; }
            set { _team = value;}
        }

        public bool IsMain 
        {
            get { return _isMain; }
            set { _isMain = value; }
        }

        public void KickFromTeam ()
        {
            _team = null;
        }

        public int HealthPoint
        {
            get { return _healthPoint; }
        }

        public int StaminaPoint
        {
            get { return _staminaPoint; }
        }

        public int MaxHealthPoint
        {
            get { return _maxHealthPoint; }
        }

        public int MaxStaminaPoint
        {
            get { return _maxStaminaPoint; }
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

        public int CurentXp
        {
            get { return _currentXp; }
        }

        public string Race
        {
            get { return _race; }
        }

        public int StatsPoint
        {
            get { return _statsPoint; }
        }

        public int SkillPoint
        {
            get { return _skillPoint; }
        }

        public Dictionary<string, Skill> Skills
        {
            get { return _skills; }
        }

        public int NextLevel
        {
            get { return _nextLevel; }
        }

        public int[] Stats
        {
            get { return new int[] { _physicalAttack, _magicAttack, _health, _robustness, _stamina, _dodge }; }
        }

        public Item ItemByPlace (string place)
        {
            return _stuffs[place];
        }

        public bool IsThisSkill (Skill skill)
        {
            if (_skills.ContainsValue(skill)) return true;
            return false;
        }

        //======================================
        //           Treatement of data
        //======================================

        public bool WearItem (Item item)
        {
            if (_team == null)
            {
                return false;
            }

            if (_stuffs[item.Type] != null) UnwearIyem(item.Type);
            _team.Invent.RemoveItem(item);
            _stuffs[item.Type] = item;
            return true;
        }

        public void UnwearIyem (string type)
        {
            _team.Invent.AddItem(_stuffs[type], 1);
            _stuffs[type] = null;
        }

        public int LevelUp(int num)
        {
            _level += 1 * num;
            _statsPoint += 10 * num;
            _skillPoint += 1 * num;
            _staminaPoint = _maxStaminaPoint;
            _healthPoint = _maxHealthPoint;
            return _level;
        }

        public void EarnXp (int xp)
        {
            while (xp > _nextLevel)
            {
                xp -= _nextLevel;
                _level++;
                _skillPoint += 1;
                _statsPoint += 5;
                _staminaPoint = _maxStaminaPoint;
                _healthPoint = _maxHealthPoint;
            }
            _currentXp += xp;

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
                        _skillPoint--;
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
                    _skillPoint--;
                    _skills.Add(name, skill);
                    return skill;
                }
            }

            return null;
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

        /// <summary>
        /// Increase stats with values that user give.
        /// </summary>
        /// <returns></returns>
        public int[] StatsUp(int PA, int MA, int H, int R, int S, int D)
        {
            if (PA + MA + H + R + S + D <= _statsPoint)
            {
                _statsPoint -= PA + MA + H + R + S + D;
                _physicalAttack += PA;
                _magicAttack += MA;
                _health += H;
                _maxHealthPoint += H * 10;
                _healthPoint += H * 10;
                _robustness += R;
                _stamina += S;
                _staminaPoint += S * 10;
                _maxStaminaPoint += S * 10;
                _dodge += D;
            }
            return new int[] { _physicalAttack, _magicAttack, _health, _robustness, _stamina, _dodge };
        }

        public int[] StatsDown(int PA, int MA, int H, int R, int S, int D)
        {
            _statsPoint += PA + MA + H + R + S + D;
            _physicalAttack -= PA;
            _magicAttack -= MA;
            _health -= H;
            _robustness -= R;
            _stamina -= S;
            _dodge -= D;
            return new int[] { _physicalAttack, _magicAttack, _health, _robustness, _stamina, _dodge };
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
                _maxStaminaPoint += 10;
                _staminaPoint += 10;
            }

            return _stamina;
        }
        public int IncreaseHealth()
        {
            if (_statsPoint > 0)
            {
                _statsPoint--;
                _health++;
                _maxHealthPoint += 10;
                _healthPoint += 10;
            }

            return _health;
        }

        public int IncreaseRobustness()
        {
            if (_statsPoint > 0)
            {
                _statsPoint--;
                _robustness++;
            }

            return _health;
        }

        public bool FrontPosition
        {
            get { return _frontPosition; }
            set { _frontPosition = value; }
        }

        public bool isAlive
        {
            get { return _isAlive; }
            set { _isAlive = value; }
        }

        public int Hurt (int damage)
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

        public int Heal(int heal)
        {
            if (heal > 0)
            {
                throw new ArgumentException();
            }

            _healthPoint += heal;

            return _healthPoint;
        }

        public bool UseSkill (Skill skill, Character target)
        {
            if ((target == this && skill.Target == 0) || skill.Target == 1)
            {
                if (IsThisSkill(skill) && skill.Cost[0] <= _healthPoint && skill.Cost[1] <= _staminaPoint)
                {
                    if ((skill.Position == 0 && _frontPosition == true) || (skill.Position == 1 && _frontPosition == true) || (skill.Position == 2 && _frontPosition == false))
                    {
                        _healthPoint -= skill.Cost[0];
                        _staminaPoint -= skill.Cost[1];
                        if (skill.Effect != null)
                        {
                            if (skill.Effect[0][0] == 0)
                            {
                                target.Hurt((skill.Effect[0][1] / 100) * _physicalAttack);
                            }
                            else if (skill.Effect[0][0] == 1)
                            {
                                target.Heal((skill.Effect[0][1] / 100) * _magicAttack);
                            }
                        }

                        return true;
                    }
                }
            }

            return false;
        }

        public bool UseConsumable (Item item)
        {
            if (item.Type != "consumable")
            {
                return false;
            }
            foreach (var effect in item.GetStats)
            {
                if (effect.Key == "heal")
                {
                    _healthPoint += effect.Value;
                    if (_healthPoint > _maxHealthPoint)
                    {
                        _healthPoint = _maxHealthPoint;
                    }
                }
                else if (effect.Key == "regainStamina")
                {
                    _staminaPoint += effect.Value;
                    if (_staminaPoint > _maxStaminaPoint)
                    {
                        _staminaPoint = _maxStaminaPoint;
                    }
                }
                else if (effect.Key == "resurection")
                {
                    
                    if (_isAlive == true)
                    {
                        return false;
                    }

                    _isAlive = true;
                    _healthPoint = _maxHealthPoint / 2;
                }
            }

            return true;
        }


    }
}
