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
            List<Monster> _monsters = new List<Monster>();

            // Create monsters
            Monster m1 = new Monster("M1", 2, "slime", 5, 0, 100, 0, 5, 5);
            Monster m2 = new Monster("M2", 2, "slime", 5, 0, 100, 0, 5, 5);
            Monster m3 = new Monster("M3", 2, "slime", 5, 0, 100, 0, 5, 5);

            // Create members
            Character c1 = new Character("C1", "HUMAIN", false);
            Character c2 = new Character("C2", "ELF", false);
            Character c3 = new Character("C3", "NAIN", false);

            MapWorld world = new MapWorld();

            // Create team
            Team _team = new Team("MyTeam");

            // Set positions to monsters
            m1.FrontPosition = true;
            m2.FrontPosition = false;
            m3.FrontPosition = false;
            // Set positions to members
            c1.IsMain = true;
            c1.FrontPosition = true;
            c2.FrontPosition = true;
            c3.FrontPosition = true;

            // Add monsters in list
            _monsters.Add(m1);
            _monsters.Add(m2);
            _monsters.Add(m3);
            // Add members in team, 
            _team.AddMembers(c1);
            _team.AddMembers(c2);
            _team.AddMembers(c3);
            // Create a fight
            Fight fight = new Fight(_monsters, _team);


            // Test
            Console.WriteLine("Avant combat");
            Console.WriteLine("Monstre 1, vie : {0}, position avant : {1}", _monsters[0].Health, _monsters[0].FrontPosition);
            Console.WriteLine("Monstre 2, vie : {0}, position avant : {1}", _monsters[1].Health, _monsters[1].FrontPosition);
            Console.WriteLine("Monstre 3, vie : {0}, position avant : {1}\n", _monsters[2].Health, _monsters[2].FrontPosition);
            Console.WriteLine("Membre  1, vie : {0}, position avant : {1}", _team.Members[0].HealthPoint, _team.Members[0].FrontPosition);
            Console.WriteLine("Membre  2, vie : {0}, position avant : {1}", _team.Members[1].HealthPoint, _team.Members[1].FrontPosition);
            Console.WriteLine("Membre  3, vie : {0}, position avant : {1} \n", _team.Members[2].HealthPoint, _team.Members[2].FrontPosition);

            //fight.gameLoop();

            Console.WriteLine("Après combat");
            Console.WriteLine("Monstre 1, vie : {0}, position avant : {1}", _monsters[0].Health, _monsters[0].FrontPosition);
            Console.WriteLine("Monstre 2, vie : {0}, position avant : {1}", _monsters[1].Health, _monsters[1].FrontPosition);
            Console.WriteLine("Monstre 3, vie : {0}, position avant : {1}\n", _monsters[2].Health, _monsters[2].FrontPosition);
            Console.WriteLine("Membre  1, vie : {0}, position avant : {1}", _team.Members[0].HealthPoint, _team.Members[0].FrontPosition);
            Console.WriteLine("Membre  2, vie : {0}, position avant : {1}", _team.Members[1].HealthPoint, _team.Members[1].FrontPosition);
            Console.WriteLine("Membre  3, vie : {0}, position avant : {1} \n", _team.Members[2].HealthPoint, _team.Members[2].FrontPosition);
        }
    }
}
