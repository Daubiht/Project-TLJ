using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    public class Fight
    {
        // bool _is EndFight is true if all the team die or if all monsters die or the team run away
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
        /// METHODS
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
                foreach ( Monster m in _monsters)
                {
                    m.Attack(_team);
                }
                _isTeamToAttack = true;
            }
            // its team's turn to attack
            else if ( _isTeamToAttack == true)
            {
                foreach ( Character c in _team.Members )
                {
                    c.Attack(_monsters);
                }
                _isTeamToAttack = false;
            }
        }
    }
}
