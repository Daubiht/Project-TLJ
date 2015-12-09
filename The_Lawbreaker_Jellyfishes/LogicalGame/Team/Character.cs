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
        // Int to know the current turn of the fight
        int _turnFight;

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
        // ===========================================
        public Dictionary<string, Item> Stuffs
        {
            get { return _stuffs; }
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
            return true;
        }

        public void UnwearItem (string type)
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

            if (_statsPoint <= 0)
            {
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

            _healthPoint += heal;

            return _healthPoint;
        }

        public bool UseSkill (Skill skill, Character target)
        {
            //Check of Target
            if ((target == this && skill.Target == 0) || skill.Target == 1)
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
                            if (skill.Effect[0] != 0)
                            //Apply effect of the used skill
                            //Hit with Physical Attack
                            {
                                target.Hurt((skill.Effect[0] / 100) * _physicalAttack);
                            }
                            else if (skill.Effect[1] != 0)
                            //Heal with Magic Attack
                            {
                                target.Heal((skill.Effect[1] / 100) * _magicAttack);
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

        //____________________MEMBERS ATTACKS MONSTER AUTOMATICALLY, DELETE THIS METHOD____________________
        // This method allows the character to attack a monster
        public void Attack(List<Monster> MonsterToKill)
        {
            // Repertory every alive FRONT MONSTERS
            List<Monster> listFrontMonsters = new List<Monster>();
            // Repertory every alive FRONT AND HIDDEN MONSTERS
            List<Monster> listHiddenMonsters = new List<Monster>();

            foreach ( Monster m in MonsterToKill )
            {
                // Add alive front monsters
               if( m.Alive == true && m.FrontPosition == true ) listFrontMonsters.Add(m);
               // Add alive front and hidden monsters
               if( m.Alive == true && m.FrontPosition == false ) listHiddenMonsters.Add(m);
            }
            // if all FRONT MONSTERS ARE DEAD, every HIDDEN MONSTERS will be set in FRONT POSITION
            if ( listFrontMonsters.Count == 0 )
            {
                foreach ( Monster m in listHiddenMonsters )
                {
                    // Change the position of the hidden monster in front
                    m.FrontPosition = true;
                    // Add the monster in the front monster list
                    listFrontMonsters.Add(m);
                }
            }

            // Check if the member is alive to attack
            if ( _isAlive == true )
            {
                Random rdm = new Random();
                // Generate a random index which represent the targetted monster in FRONT POSITION
                int indexRdmMonster = rdm.Next(0, listFrontMonsters.Count);
                listFrontMonsters[indexRdmMonster].Hurt(_physicalAttack);
            }
        }
        //__________________ MEMBERS ATTACKS MONSTER USING THE MOUSE USER__________________
        public void AttackMonster(Monster AttackedMonster)
        {
            AttackedMonster.Hurt(_physicalAttack);
        }
    }
}
