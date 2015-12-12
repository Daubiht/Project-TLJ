﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LogicalGame
{
    public class Fight
    {
        // Bool to know if all monster are members, if yes, we create a new screen
        bool _areAllMembersDead;
        // Bool to know if all monster are dead, if yes, we create a new screen which display what the team earn
        bool _areAllMonsterDead;
        // Count the number of turn
        int _turn;
        /// Fields used to attack a monster
        // Get the member who attacks, used in the method who gets the member who attacks
        Character _memberWhoAttacks;
        // Skill of the member launched on a monster
        Skill _selectedSkill;
        // Member's basic attack used on a monster
        int _basicAttack;

        // A dictionnary of dictionnaries, a dictionnary will contain the original basic stats of the members
        Dictionary<Character, Dictionary<string, int>> _OriginalBasicStats;

        // Bool to know if a member is attacking, usefull in case the player clicks everywhere during the fight
        bool _doesAMemberAttack;

        // Get the attacked monster
        Monster _attackedMonster;

        // current team who fights
        Team _team;

        List<Monster> _monstersList;

        // Create a Front and Hidden monsters list, usefull for longshot skill, usefull to place hidden monster in front monster list if they are all dead
        List<Monster> _FrontMonsterList;
        List<Monster> _HiddenMonsterList;

        // Constructor
        public Fight(List<Monster> MonstersToKill, Team TeamWhoFights)
        {
            // Count the number of turn
            _turn = 1;
            _team = TeamWhoFights;
            _monstersList = MonstersToKill;
            _FrontMonsterList = new List<Monster>();
            _HiddenMonsterList = new List<Monster>();
            _OriginalBasicStats = new Dictionary<Character, Dictionary<string, int>>();
            foreach (Monster m in _monstersList )
            {
                // Add FRONT monsters in _FrontMonsterList
                if ( m.FrontPosition == true )
                    _FrontMonsterList.Add(m);
                // Add HIDDEN monsters in _HiddenMonster
                else if ( m.FrontPosition == false )
                    _HiddenMonsterList.Add(m);
            }
            // We save all the basic stats of all member, usefull at the end of the fight to reset all the basic stats which could be modify by skills or effects
            OriginaleStats();
            FalseDidMemberPlay();
        }
        /// <summary>
        // METHODS
        /// </summary>

        // Check if all MONSTERS are dead
        public bool IsAllMonsterDie()
        {
            foreach ( Monster m in _monstersList)
            {   
                if ( m.Alive == true ) return false; // False means "No, some monsters  alive"
            }
            _areAllMonsterDead = true;
            return true; // True means "Yes, they are all dead"
        }

        // Check if all MEMBERS are DEAD
        public void IsAllMemberDie()
        {
            // if localBool == true, it means all the team is dead
            bool localBool = true;
            foreach ( Character c in _team.Members)
            {
                if ( c.isAlive == true )
                {
                    // False means "No there is still a member alive"
                    _areAllMembersDead = false;
                    localBool = false;
                }
            }
            // if localBool == true, it means all the team is dead
            if ( localBool == true ) _areAllMembersDead = true;
        }
        // Every monster attack
        public bool MonsterAttack()
        {
            // Monsters attack members
            foreach ( Monster m in _monstersList )
            {
                // If some members are alive, monster continue to attack
                m.Attack(_team);
                // Check if all members are dead, if yes, we create a game over screen
                IsAllMemberDie();
                if ( _areAllMembersDead == true ) { return true; }
            }
            // After all monsters attack, we enabled all the team to play again
            foreach ( Character c in _team.Members )
            {
                if( c.isAlive == true )
                    c.DidMemberPlay = false;
            }
            // Increment the number of turn
            IncrementTurn();
            // When the monsters finished to attack, we check and disabled skill used by the members like "defense" button
            foreach ( Character c in _team.Members )
                c.CheckEndSkill(_turn);
            return false;
        }

        // 1 METHODS TO GET THE MEMBER WHO ATTACKS, this method is called when the player clicks on a member's panel
        public void GetMemberWhoAttack(Character MemberWhoAttacks, Skill SelectedSkill, int BasicAttack)
        {
            // Get the member who attacks
            _memberWhoAttacks = MemberWhoAttacks;
            // Get the launched skill
            _selectedSkill = SelectedSkill;
            // Get the used basic attack
            _basicAttack = BasicAttack;
            // True means "A member of the team is attacking"
            _doesAMemberAttack = true;
        }
        // 2 METHOD TO GET THE ATTACKED MONSTER, this method is called when the player clicks on a monster's panel
        public bool GetAttackedMonster(Monster AttackedMonster)
        {
            // Check if the player has selected a member before clicking on a monster's panel
            if (_memberWhoAttacks != null)
            {
                // Check if the member is ALIVE has NOT ALREADY ATTACKED a monster AND check if a member is attacking, it's avoid the player to click randomly by clicking everywhere on the screen
                if ( _memberWhoAttacks.isAlive == true && _memberWhoAttacks.DidMemberPlay == false
                    && _doesAMemberAttack == true && AttackedMonster.FrontPosition == true && AttackedMonster.Alive == true )
                {
                    _attackedMonster = AttackedMonster;
                    // Match the member who is attacking and the attacked monster
                    if ( HitMonster(_memberWhoAttacks, _attackedMonster) == true )
                        return true; // True means "All monsters attacked"
                }
                else _memberWhoAttacks.SuccedAttack = false;
            }
            return false;
        }
        // 3 METHOD WHO MATCHES THE MEMBER WHO ATTACKS AND THE ATTACKED MONSTER
        public bool HitMonster(Character MemberWhoAttacks, Monster AttackedMonster)
        {
            // Count how many member is in the team
            int numberOfMembers = _team.Members.Count();
            // Count how many player has launched an attack
            int memberWhoPlayed = 0;

            MemberWhoAttacks.AttackMonster(AttackedMonster);
            // When the member finish to attack, now nobody in the team is attacking
            _doesAMemberAttack = false;
            _memberWhoAttacks.SuccedAttack = true;
            // True means "This member just attacked, he won't be able to attack again"
            MemberWhoAttacks.DidMemberPlay = true;

            // Check if all monsters are dead, if yes, we end the fight and we create a screen who dislays what the team earn
            if ( IsAllMonsterDie() == true ) return true;

            // Check if all member played, if not, the player can continue to attack the monsters
            foreach ( Character c in _team.Members )
            {
                if ( c.DidMemberPlay == true )
                {
                    memberWhoPlayed += 1;
                    CheckFrontMonserDead();
                }
            }
            // If all member played, monsters attack
            if ( numberOfMembers == memberWhoPlayed )
            {
                MonsterAttack();
                // True means "All monsters attacked" 
                return true; 
            }
            return false;
        }


        //_____METHOD WHO CHECKS IF ALL FRONT MONSTER ARE DEAD TO PUT HIDDEN MONSTER IN FRONT POSITION
        public void CheckFrontMonserDead()
        {
            // Bool to know if front monsters are dead
            bool areAllFrontMonstersDead = false;
            foreach ( Monster m in _FrontMonsterList )
                // if a front monster is alive, areAllFrontMonstersDead is true
                if ( m.Alive == true )
                    areAllFrontMonstersDead = true;
            // If areAllFrontMonstersDead is false, we place all hidden monster in front monster list
            if ( areAllFrontMonstersDead == false )
            {
                foreach ( Monster m in _HiddenMonsterList )
                {
                    m.FrontPosition = true;
                    _FrontMonsterList.Add(m);
                }
            }
        }
        // ____METHODE TO INCREMENT THE NUMBER OF TURNS
        public void IncrementTurn()
        { _turn += 1; }
        //_____Method to reset all the basic stats of members at the end of the fight, basic stats could change during the fight so we need to reset them
        public void OriginaleStats()
        {
            foreach ( Character c in _team.Members )
            {
                // Create a dictionnary which contains the basic stats
                Dictionary<string, int> basicStats = new Dictionary<string, int>();
                basicStats.Add("attaque physique", c.PhysicalAttack);
                basicStats.Add("attaque magique", c.MagicAttack);
                basicStats.Add("esquive", c.Dodge);
                basicStats.Add("robustesse", c.Robustness);
                // Classify the stats of the character in a dictionnary
                _OriginalBasicStats.Add(c, basicStats);
            }
        }
        //_____Method to set bool "DidMemeberPlay" as false for every member, use in the begining of the fight, in the constructor's fight
        public void FalseDidMemberPlay()
        {
            foreach (Character c in _team.Members )
            {
                c.DidMemberPlay = false;
            }
        }

        public Dictionary<Character, Dictionary<string, int>> OriginalStats { get { return _OriginalBasicStats; } }
        public bool AreAllMembersDead { get { return _areAllMembersDead; } }
        public bool AreAllMonstersDead { get { return _areAllMonsterDead; } }
        public Team GetTeam{get { return _team; }}
        public List<Monster> GetFrontMonsters { get { return _FrontMonsterList; } }
        public List<Monster> GetHiddenMonster { get { return _HiddenMonsterList; } }
        public List<Monster> GetAllMonster { get { return _monstersList; } }
        public Character MemberWhoIsAttacking { get { return _memberWhoAttacks;  } }
        public int NumberTurn { get { return _turn; } }
    }
}