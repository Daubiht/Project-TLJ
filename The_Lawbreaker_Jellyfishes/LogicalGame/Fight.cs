using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LogicalGame
{
    public class Fight
    {
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
        List<Monster> _monsters;

        // Constructor
        public Fight(List<Monster> MonstersToKill, Team TeamWhoFights)
        {
            _monsters = MonstersToKill;
            _team = TeamWhoFights;
            _isEndFight = false;
        }
        /// <summary>
        // METHODS
        /// </summary>

        // Check if all MONSTERS are dead
        public bool IsAllMonsterDie()
        {
            foreach ( Monster m in _monsters)
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
            foreach ( Monster m in _monsters)
                m.Attack(_team);
            // After all monsters attack, we enabled all the team to play again
            foreach ( Character c in _team.Members )
                c.DidMemberPlay = false;
        }

        // __________METHODS TO GET THE MEMBER WHO ATTACKS, this method is called when the player clicks on a member's panel
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
        public bool GetAttackedMonster(Monster AttackedMonster)
        {
            // Check if the player has selected a member before clicking on a monster's panel
            if (_memberWhoAttacks != null)
            {
                // Check if the member has not already attacked a monster AND check if a member is attacking, it's avoid the player to click randomly by clicking everywhere on the screen
                if ( _memberWhoAttacks.DidMemberPlay == false && _doesAMemberAttack == true && AttackedMonster.FrontPosition == true)
                {
                    _attackedMonster = AttackedMonster;
                    // Match the member who is attacking and the attacked monster
                    if ( HitMonster(_memberWhoAttacks, _attackedMonster) == true )
                        return true; // True means "All monsters attacked"
                }
            }
            return false;
        }
        // ________METHOD WHO MATCHES THE MEMBER WHO ATTACKS AND THE ATTACKED MONSTER
        public bool HitMonster(Character MemberWhoAttacks, Monster AttackedMonster)
        {
            int numberOfMembers = _team.Members.Count();
            int memberWhoPlayed = 0;

            MemberWhoAttacks.AttackMonster(AttackedMonster);
            // When the member finish to attack, now nobody in the team is attacking
            _doesAMemberAttack = false;
            // True means "This member just attacked, he won't be able to attack again"
            MemberWhoAttacks.DidMemberPlay = true;

            // Check if all member played, if not, the player can continue to attack the monsters
            foreach ( Character c in _team.Members )
            {
                if ( c.DidMemberPlay == true )
                    memberWhoPlayed += 1;
            }
            // If all member played, monsters attack
            if ( numberOfMembers == memberWhoPlayed )
            {
                MonsterAttack();
                return true; // True means "All monsters attacked" 
            }
            return false;
        }

        public Team GetTeam{get { return _team; }}
    }
}
