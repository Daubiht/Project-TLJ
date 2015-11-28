using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame.Test
{
    [TestFixture]
    class FightTest
    {
        [Test]
        public void Create_a_fight()
        {
            // Create monster
            Monster m1 = new Monster("M1", "slime", 10, 0, 100, 0, 5, 5);
            Monster m2 = new Monster("M2", "slime", 10, 0, 100, 0, 5, 5);
            Monster m3 = new Monster("M3", "slime", 10, 0, 100, 0, 5, 5);
            m2.FrontPosition = false;
            m3.FrontPosition = false;
            List<Monster> _monsters = new List<Monster>();
            _monsters.Add(m1);
            _monsters.Add(m2);
            _monsters.Add(m3);

            // Create team
            Team _team = new Team("MyTeam");

            // Create member and add to team
            Character c1 = new Character("C1", "HUMAIN", false);
            Character c2 = new Character("C2", "ELF", false);
            Character c3 = new Character("C3", "NAIN", false);
            c2.FrontPosition = false;
            c3.FrontPosition = false;
            _team.AddMembers(c1);
            _team.AddMembers(c2);
            _team.AddMembers(c3);


            Fight fight = new Fight(_monsters, _team);
            fight.gameLoop();
        }
    }
}
