using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LogicalGame
{
    public class Fight
    {
        // Count the number of turn
        int _turn;
        /// Fields used to attack a monster
        // Get the member who attacks, used in the method who gets the member who attacks
        Character _memberWhoAttacks;
        // Skill of the member launched on a monster
        Skill _selectedSkill;
        // Member's basic attack used on a monster
        int _basicAttack;

        // Bool to know if a member is attacking, usefull in case the player clicks everywhere during the fight
        bool _doesAMemberAttack;

        // Get the attacked monster
        Monster _attackedMonster;

        // bool _isEndFight is true if all the team die or if all monsters die or the team run away
        bool _isEndFight;

        // current team who fights
        Team _team;
        // team to save the basic stats of members, used to reset the basic stats after using a skill who boosted the basic stats
        Team _teamResetStat;
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
            _isEndFight = false;
            _FrontMonsterList = new List<Monster>();
            _HiddenMonsterList = new List<Monster>();

            foreach(Monster m in _monstersList )
            {
                // Add FRONT monsters in _FrontMonsterList
                if ( m.FrontPosition == true )
                    _FrontMonsterList.Add(m);
                // Add HIDDEN monsters in _HiddenMonster
                else if ( m.FrontPosition == false )
                    _HiddenMonsterList.Add(m);
            }
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
            return true; // True means "Yes, they are all dead"
        }

        // Check if all MEMBERS are DEAD
        public bool IsAllMemberDie()
        {
            foreach ( Character c in _team.Members)
            {   
                if ( c.isAlive == true ) return false; // False means "No there is still a member alive"
            }  
            return true; // True means "Yes, all member are dead"
        }
        // Every monster attack
        public void MonsterAttack()
        {
            // Monsters attack members
            foreach ( Monster m in _monstersList)
                m.Attack(_team);
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
        }

        // ____METHODS TO GET THE MEMBER WHO ATTACKS, this method is called when the player clicks on a member's panel
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
        //_____METHOD TO GET THE ATTACKED MONSTER, this method is called when the player clicks on a monster's panel
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
        // ____METHOD WHO MATCHES THE MEMBER WHO ATTACKS AND THE ATTACKED MONSTER
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


        public Team GetTeam{get { return _team; }}
        public List<Monster> GetFrontMonsters { get { return _FrontMonsterList; } }
        public List<Monster> GetHiddenMonster { get { return _HiddenMonsterList; } }
        public Character MemberWhoIsAttacking { get { return _memberWhoAttacks;  } }
        public int NumberTurn { get { return _turn; } }
    }
}
