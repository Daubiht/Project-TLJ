using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LogicalGame
{
    public class Fight
    {
        // Put on pause the code until the member attacks a monster
        ManualResetEvent _suspendEvent = new ManualResetEvent(true);

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

        // bool to know if it's the turn of the team to attack
        bool _isTeamToAttack;

        // current team who fights
        Team _team;
        List<Monster> _monsters;

        // Constructor
        public Fight(List<Monster> MonstersToKill, Team TeamWhoFights)
        {
            _monsters = MonstersToKill;
            _team = TeamWhoFights;
            _isEndFight = false;
        }
        
        // Main game loop
        public void gameLoop()
        {
            // while the fight is not finished we continue to play
            while( _isEndFight == false )
            {
                // Check if all member are dead or all monster are dead
                // If one of the bools is true, it means the fight is finished. If not, we continue to play
                if ( IsAllMemberDie() || IsAllMonsterDie() )
                {
                   _isEndFight = true;
                }
                // Check who attacks
                IsTeamToAttack();
                gameLoop();
            } 
        }

        /// <summary>
        // METHODS
        /// </summary>

        // Check if all MONSTERS are dead
        // False means "No, some monsters  alive"
        // True means "Yes, they are all dead"
        public bool IsAllMonsterDie()
        {
            foreach ( Monster m in _monsters)
            {   
                if ( m.Alive == true ) return false; // False means "No, some monsters  alive"
            }  
            return true; // True means "Yes, they are all dead"
        }

        // Check if all MEMBERS are DEAD
        // False means "No there is still a member alive"
        // True means "Yes, all member are dead"
        public bool IsAllMemberDie()
        {
            foreach ( Character c in _team.Members)
            {   
                if ( c.isAlive == true ) return false; // False means "No there is still a member alive"
            }  
            return true; // True means "Yes, all member are dead"
        }
        // Check if its monster's turn or team's turn to attack
        public void IsTeamToAttack()
        {
            // its monter's turn to attack
            if ( _isTeamToAttack == false )
            {
                // Monsters attack members
                foreach ( Monster m in _monsters)
                    m.Attack(_team);
                // We define that the members hasn't play yet
                foreach (Character c in _team.Members)
                    c.DidMemberPlay = false;
                _isTeamToAttack = true;
            }
            // its team's turn to attack
            else if ( _isTeamToAttack == true )
            {
                foreach( Character member in _team.Members )
                {
                    // While a member hasn't play yet, we wait him to attack
                    while (member.DidMemberPlay == false)
                    {   // call the team to attack again and again until every member has attacked
                        //IsTeamToAttack();
                        // __________________ PUT A WAIT CLICK EVENT HANDLER HERE
                        _suspendEvent.WaitOne();
                        
                        
                    }
                }
                _isTeamToAttack = false;
            }
        }

        // __________METHODS TO GET THE MEMBER WHO ATTACKS , this method is called when the player clicks on a member's panel
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
        //__________METHOD TO GET THE ATTACKED MONSTER, this method is called when the player clicks on a monster's panel
        public void GetAttackedMonster(Monster AttackedMonster)
        {
            // Check if the member has not already attacked a monster
            // And check if a member is attacking, it's avoid the player to click randomly by clicking everywhere on the screen
            if ( _memberWhoAttacks.DidMemberPlay == false & _doesAMemberAttack == true )
            {
                _attackedMonster = AttackedMonster;
                // Match the member and the monster
                AttackAMonster(_memberWhoAttacks, _attackedMonster);
            }
        }
        // ________METHOD WHO MATCHES THE MEMBER WHO ATTACKS AND THE ATTACKED MONSTER
        public void AttackAMonster(Character MemberWhoAttacks, Monster AttackedMonster)
        {
            MemberWhoAttacks.AttackMonster(AttackedMonster);
            // When the member finish to attack, now nobody is attacking
            _doesAMemberAttack = false;
            // True means "This member just attacked, he won't be able to attack again"
            MemberWhoAttacks.DidMemberPlay = true;
        }
    }
}
