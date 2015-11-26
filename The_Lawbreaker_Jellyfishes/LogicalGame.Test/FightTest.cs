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
            Monster m1 = new Monster("Slime Immature", "slime", 10, 0, 200, 0, 5, 5);
            Monster m2 = new Monster("xcvcxvcxvx cxvcxv", "slime", 10, 0, 200, 0, 5, 5);

            List<Monster> _monsters = new List<Monster>();
            _monsters.Add(m1);
            _monsters.Add(m2);

            // Create team
            Team _team = new Team("MyTeam");

            // Create member and add to team
            Character c1 = new Character("C1", "HUMAIN", false);
            Character c2 = new Character("C2", "ELF", false);
            _team.AddMembers(c1);
            _team.AddMembers(c2);

            Fight fight = new Fight(_monsters, _team);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Vie du membre : HealthPoint {0}", _team.Members[0].HealthPoint);
                fight.gameLoop();
            }

    }
    }
}
