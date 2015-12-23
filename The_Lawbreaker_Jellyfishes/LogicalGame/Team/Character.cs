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

        // Bool to know if the member has already attacked a monster, if yes, he cant attack again
        bool _didPlay;
        bool _succceedLauchAttack;
        // Int to know at what turn finish the defense skill (increase robusntessduring 1 turn)
        int _endDefenseTurn;
        int _purcentIncreaseRobustness;
        // Dictionnary which contains the original stats of the member, usefull to reset all the stats of a member when the fight is end
        readonly Dictionary <String, int> _originaleBasicStats;

        readonly Dictionary<String, Skill> _skills;
        readonly Dictionary<string, Item> _stuffs;


        /// <summary>
        /// Create a new character who is level one.
        /// </summary>
        /// <param name="name">The name of the character</param>
        /// <param race="race">The race of the character (Dwarf, Giant, Human, etc.</param>
        public Character( string name, string race, bool isFemale )
        {
            _isAlive = true;
            _isFemale = isFemale;
            _race = race;
            _name = name;
            _level = 1;
            _physicalAttack = 5;
            _magicAttack = 5;
            _health = 5;
            _stamina = 5;
            _robustness = 5;
            _dodge = 5;
            _nextLevel = 100;
            _currentXp = 0;
            _statsPoint = 10;
            _skillPoint = 1;

            _maxStaminaPoint = 5;
            _maxHealthPoint = 100;
            _staminaPoint = 5;
            _healthPoint = 100;

            _frontPosition = true;

            _skills = new Dictionary<string, Skill>();
            _stuffs = new Dictionary<string, Item>();

            _originaleBasicStats = new Dictionary<string, int>();
            _originaleBasicStats.Add("attaque physique", _physicalAttack);
            _originaleBasicStats.Add("attaque magique", _magicAttack);
            _originaleBasicStats.Add("esquive", _dodge);
            _originaleBasicStats.Add("robustesse", _robustness);
        }

        //==================================================
        //               Get some stuff
        //==================================================


        // Added by Jerome ===================================
        public bool SuccedAttack
        {
            get { return _succceedLauchAttack; }
            set { _succceedLauchAttack = value; }
        }
        // Bool to know if the charater has already plays
        public bool DidMemberPlay
        {
            get { return _didPlay; }
            set { _didPlay = value; }
        }

        public Dictionary<String,int> OriginalStats { get { return _originaleBasicStats; } }
        // ===========================================
        public Dictionary<string, Item> Stuffs
        {
            get { return _stuffs; }
        }

        public int StaminaPoint
        {
            get { return _staminaPoint; }
            set { _staminaPoint = value; }
        }

        public int MaxStaminaPoint
        {
            get { return _maxStaminaPoint; }
            set { _maxStaminaPoint = value; }
        }

        public Dictionary<string, int> StatsStuff
        {
            get
            {
                Dictionary<string, int> dictio = new Dictionary<string, int>();

                foreach (string position in _stuffs.Keys)
                {
                    foreach (string bonus in _stuffs[position].GetStats.Keys)
                    {
                        if(dictio.ContainsKey(bonus))
                        {
                            dictio[bonus] += _stuffs[position].GetStats[bonus];
                        }
                        else
                        {
                            dictio.Add(bonus, _stuffs[position].GetStats[bonus]);
                        }
                    }
                }

                return dictio;
            }
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
            set { _healthPoint = value; } // basic stats
        }

        public int MaxHealthPoint
        {
            get { return _maxHealthPoint; }
            set { _maxHealthPoint = value; }
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
        // Basic stats
        public int PhysicalAttack
        {
            get { return _physicalAttack; }
            set { _physicalAttack = value; }
        }

        

        public int MagicAttack
        {
            get { return _magicAttack; }
            set { _magicAttack = value; }
        }

        public int Dodge
        {
            get { return _dodge; }
            set { _dodge = value; }
        }

        public int Stamina
        {
            get { return _stamina; }
            set { _stamina = value; }
        }
        // Basic stats

        public int Health
        {
            get { return _health; }
        }

        public int Robustness
        {
            get { return _robustness; }
            set { _robustness = value; } // Set used to increase robustness when the player click on "defense" button, in this class used by public void Defense(int NumberOfTurnFight)
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


        // ============METHOD ADDED BY JEROME

        // ___METHOD DEFENSE to increase robustness when the player clicks on "defense" button
        public void Defense(int NumberOfTurnFight)
        {
            // the defense ends at x+1 turn, x is the number of current turn of fight, "1" is the number of turn the skill is actived
            _endDefenseTurn = NumberOfTurnFight + 1;
            // Define the number of point we increase the robustness, then we will remove these point when the skill is finished
            _purcentIncreaseRobustness = (int) Math.Ceiling ( 500.0 / 100 * Robustness );
            int temporaryRobustness = Robustness + _purcentIncreaseRobustness;
            // Add the point on the current robustness
            Robustness = temporaryRobustness;
        }

        // This method will check if the skills 
        public void CheckEndSkill(int NumberOfTurnFight)
        {
            // Defense ends, remove the point added by "defense" buttton, when the skill arrived to its end turn fight
            if( _endDefenseTurn == NumberOfTurnFight )
                Robustness -= _purcentIncreaseRobustness;
        }

        // ==================================
        public bool WearItem (Item item, string place)
        {
            if (_team == null)
            {
                return false;
            }

            if (place == null)
            {
                place = item.Type;

            }

            if (_stuffs.ContainsKey(place) && _stuffs[place] != null) UnwearItem(place);
            _team.Invent.RemoveItem(item);
            _stuffs[place] = item;

            foreach (string effect in item.GetStats.Keys)
            {
                if (effect == "vie")
                {
                    _maxHealthPoint += item.GetStats["vie"] * 10;
                    if (_maxHealthPoint == _healthPoint) _healthPoint += item.GetStats["vie"] * 10;
                }
                else if (effect == "fatigue")
                {
                    _maxStaminaPoint += item.GetStats["fatigue"];
                    if (_maxHealthPoint == _healthPoint) _healthPoint += item.GetStats["fatigue"];
                }
            }

            return true;
        }

        public void UnwearItem (string type)
        {
            Item item = _stuffs[type];
            _team.Invent.AddItem(_stuffs[type], 1);
            _stuffs[type] = null;

            foreach (string effect in item.GetStats.Keys)
            {
                if (effect == "vie")
                {
                    _maxHealthPoint -= item.GetStats["vie"] * 10;
                    if (_maxHealthPoint == _healthPoint) _healthPoint -= item.GetStats["vie"] * 10;
                }
                else if (effect == "fatigue")
                {
                    _maxStaminaPoint -= item.GetStats["fatigue"];
                    if (_maxHealthPoint == _healthPoint) _healthPoint -= item.GetStats["fatigue"];
                }
            }
        }

        public int LevelUp(int num)
        {
            _level += 1 * num;
            _statsPoint += 5 * num;
            _skillPoint += 1 * num;
            _currentXp = 0;
            _staminaPoint = _maxStaminaPoint;
            _healthPoint = _maxHealthPoint;
            return _level;
        }

        public void EarnXp (int xp)
        {
            if (_isAlive)
            {
                while (xp + _currentXp >= _nextLevel)
                {
                    xp -= _nextLevel - _currentXp;
                    LevelUp(1);
                }
                _currentXp += xp;
            }

        }
         
        public Skill AddSkill (string name, Skill skill)
        {
            int[] stat = skill.statRequired;

            if (_skillPoint >= 0)
            {
                if (stat == null || (stat[0] <= _physicalAttack && stat[1] <= _magicAttack && stat[2] <= _health && stat[3] <= _robustness && stat[4] <= _stamina && stat[5] <= _dodge))
                {
                    if (skill.PreviousSkill != null)
                    {
                        if (_skills.ContainsKey(skill.PreviousSkill.Name))
                        {
                            _skillPoint--;
                            _skills.Add(name, skill);

                            if (skill.IsPassif)
                            {
                                int effectPower;
                                foreach (string effect in skill.Effect.Keys)
                                {
                                    effectPower = skill.Effect[effect];

                                    switch (effect)
                                    {
                                        case "vie":
                                            _maxHealthPoint += effectPower * 5;
                                            if(_healthPoint == _maxHealthPoint) _healthPoint = _maxHealthPoint;
                                            _health += effectPower;
                                            break;
                                        case "attaque physique":
                                            _physicalAttack += effectPower;
                                            break;
                                        case "attaque magique":
                                            _magicAttack += effectPower;
                                            break;
                                        case "robustesse":
                                            _robustness += effectPower;
                                            break;
                                        case "esquive":
                                            _dodge += effectPower;
                                            break;
                                        case "fatigue":
                                            _stamina += effectPower;
                                            break;
                                    }
                                }
                            }

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
                _staminaPoint += S;
                _maxStaminaPoint += S;
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

            _maxStaminaPoint += 1 * S;
            _staminaPoint += 1 * S;
            _maxStaminaPoint += 1 * H;
            _staminaPoint += 1 * H;

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
                _maxStaminaPoint += 1;
                _staminaPoint += 1;
            }

            return _stamina;
        }
        public int IncreaseHealth()
        {
            if (_statsPoint > 0)
            {
                _statsPoint--;
                _health++;
                _maxHealthPoint += 3;
                _healthPoint += 3;
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
        // ________________ METHOD TO REMOVE HP OF THE CHARACTER BECAUSE A MONSTER LAUNCHED AN ATTACK
        public int Hurt (int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentException();
            }
            // ============ DODGE =================================
            Random r = new Random();            // Chance to dodge the the attack
            int chanceToDodge = r.Next(0, 101); // Random between 0 and 100
            if ( chanceToDodge <= Dodge / 2 )   // If chanceToDodge is equal to dodge / 2, the character dodges the attack of the monster
                damage = 0;
            // ============ ROBUSTNESS   ========================
            // The damage launched on the character is reduced thanks to the character's robustness
            damage = damage - (int) Math.Ceiling(Robustness/100.0*damage); // Math.Ceiling around to the superior bound, 0.3 become 1.0
            // If damage is under 0 because the character has too much robustness, it will give healt point to the character because of a bug, so we set the value to 5
            if ( damage < 5  ) damage = 5;
            // Remove HP
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
            if (heal < 0)
            {
                throw new ArgumentException();
            }

            if(isAlive)
            {
                if (_healthPoint + heal <= _maxHealthPoint) _healthPoint += heal;
                else _healthPoint = _maxHealthPoint;

            }

            return _healthPoint;
        }

        public bool UseSkill (Skill skill, Character target)
        {
            //Check of Target
            //if ((target == this && skill.Target == 0) || skill.Target == 1)
            //{
                //Check of cost in Health and Stamina
                if (IsThisSkill(skill) && skill.Cost[0] <= _healthPoint && skill.Cost[1] <= _staminaPoint)
                {
                    //Check of Position of caster and target
                    if (skill.Position == 0  || (skill.Position == 1 && _frontPosition == true) || (skill.Position == 2 && _frontPosition == false))
                    {
                        if (skill.Effect != null)
                        {
                            _healthPoint -= skill.Cost[0];
                            _staminaPoint -= skill.Cost[1];
                            foreach (string name in skill.Effect.Keys)
                            {
                                int effect = skill.Effect[name];
                                switch (name)
                                {
                                    case "attaque physique":
                                        target.Hurt((effect / 100) * _physicalAttack);
                                        break;
                                    case "attaque magique":
                                        target.Hurt((effect / 100) * _magicAttack);
                                        break;
                                    case "soin":
                                        target.Heal((int)Math.Round(((decimal)effect / 100) * _magicAttack));
                                        break;
                                    case "fatigue":
                                        target.StaminaPoint = StaminaPoint - effect;
                                        break;
                                    case "baisse vie":
                                        target.MaxHealthPoint = target.MaxHealthPoint - (int)Math.Round(target.MaxHealthPoint * (double)(effect / 100));
                                        if (target.MaxHealthPoint < target.HealthPoint) target.HealthPoint = target.MaxHealthPoint;
                                        break;
                                    case "gain fatigue":
                                        _staminaPoint += effect;
                                        if (_staminaPoint > _maxStaminaPoint) _staminaPoint = _maxStaminaPoint;
                                        break;
                                }
                            }

                            return true;
                        }
                    }
                //}
            }

            return false;
        }

        public bool UseSkill(Skill skill, Monster target)
        {
            //Check of Target
            if ((skill.Target == 0) || skill.Target == 1)
            {
                //Check of cost in Health and Stamina
                if (IsThisSkill(skill) && skill.Cost[0] <= _healthPoint && skill.Cost[1] <= _staminaPoint)
                {
                    //Check of Position of caster and target
                    if (skill.Position == 0|| (skill.Position == 1 && _frontPosition == true) || (skill.Position == 2 && _frontPosition == false))
                    {
                        _healthPoint -= skill.Cost[0];
                        _staminaPoint -= skill.Cost[1];
                        if (skill.Effect != null)
                        {
                            foreach (string name in skill.Effect.Keys)
                            {
                                //Apply effect of the used skill
                                //Hit with Physical Attack
                                int effect = skill.Effect[name];
                                switch (name)
                                {
                                    case "attaque physique":
                                        target.Hurt((effect / 100) * _physicalAttack);
                                        break;
                                    case "attaque magique":
                                        target.Hurt((effect / 100) * _magicAttack);
                                        break;
                                    case "soin":
                                        target.Heal((effect / 100) * _magicAttack);
                                        break;
                                    case "fatigue":
                                        target.StaminaPoint = StaminaPoint - effect;
                                        break;
                                    case "baisse vie":
                                        target.MaxHealthPoint = target.MaxHealthPoint - (int)Math.Round(target.MaxHealthPoint*(double)(effect/100));
                                        if (target.MaxHealthPoint < target.HealthPoint) target.HealthPoint = target.MaxHealthPoint;
                                        break;
                                }
                            }
                        }

                        return true;
                    }
                }
            }

            return false;
        }

        public bool UseSkill(Skill skill, Team targetTeam)
        {
            //Check of Target
            if ((skill.Target == 0) || skill.Target == 1)
            {
                //Check of cost in Health and Stamina
                if (IsThisSkill(skill) && skill.Cost[0] <= _healthPoint && skill.Cost[1] <= _staminaPoint)
                {
                    //Check of Position of caster and target
                    if ((skill.Position == 0 && _frontPosition == true) || (skill.Position == 1 && _frontPosition == true) || (skill.Position == 2 && _frontPosition == false))
                    {
                        _healthPoint -= skill.Cost[0];
                        _staminaPoint -= skill.Cost[1];
                        if (skill.Effect != null)
                        {
                            foreach (string name in skill.Effect.Keys)
                            {
                                //Apply effect of the used skill
                                //Hit with Physical Attack
                                int effect = skill.Effect[name];
                                switch (name)
                                {
                                    case "soin team":
                                        foreach (var target in targetTeam.Members)
                                        {
                                            target.Heal((effect / 100) * _magicAttack);
                                        }
                                        break;
                                }
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
            if (item.Type != "consommable")
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

        //__________________ MEMBERS ATTACKS MONSTER USING THE MOUSE USER__________________
        public void AttackMonster(Monster AttackedMonster)
        {
            AttackedMonster.Hurt(_physicalAttack);
        }
    }
}
