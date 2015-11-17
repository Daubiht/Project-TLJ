using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame.Test
{
    [TestFixture]
    class TeamTest
    {
        [Test]
        public void Test_to_create_a_team()
        {
            Team team = new Team("Team1");
            Assert.AreEqual("Team1", team.Name);
        }

        [Test]
        public void Test_to_add_members_in_the_team()
        {
            Team team = new Team("Team1");
            Character memberToAdd = new Character("memberAdded", "Geant", false);

            team.AddMembers(memberToAdd);

            Assert.AreEqual(memberToAdd, team.Members[0]);
            Assert.AreEqual(1, team.Members.Count);
        }
        [Test]
        public void Test_to_remove_members_in_the_team()
        {
            Team team = new Team("Team1");
            Character c1 = new Character("Character1", "Geant", false);
            Character c2 = new Character("Character2", "Geant", false);

            team.AddMembers(c1);
            team.AddMembers(c2);

            Assert.AreEqual(2, team.Members.Count);
            team.RemoveMembers(c1);
            Assert.AreEqual(1, team.Members.Count);
        }

        [Test]
        public void Test_to_change_the_position_of_a_character()
        {
            Character character = new Character("Character1", "Geant", false);
            Team team = new Team("Team1");
            team.AddMembers(character);

            // Change the position of the main character with "True"
            team.ChangePositionMember(character, true);
            Assert.AreEqual(true, team.Members[0].FrontPosition);
        }
        [Test]
        public void Get_the_inventory_of_the_team()
        {
            Team team = new Team("Team1");
            Invent inventory = new Invent(team);
            team.Invent.AddGold(100);
            Assert.AreEqual(100, team.Invent.GetGold);        
        }
        [Test] 
        public void Test_to_verify_we_cant_add_members_if_the_team_is_full()
        {
            Team team = new Team("Team1");
            Character c1 = new Character("c1", "humain", false);
            Character c2 = new Character("c2", "humain", false);
            Character c3 = new Character("c3", "humain", false);
            Character c4 = new Character("c4", "humain", false);
            Character c5 = new Character("c5", "humain", false);

            team.AddMembers(c1);
            team.AddMembers(c2);
            team.AddMembers(c3);
            team.AddMembers(c4);
            team.AddMembers(c5); // this member wil not be in the team because the mamximum member is 4

            Assert.AreEqual(4, team.Members.Count);
        }
        [Test]
        public void Test_we_cant_remove_the_main_character()
        {
            Team team = new Team("Team1");
            Character c1 = new Character("c1", "humain", false);

            c1.IsMain = true; // set the member to main character
            team.AddMembers(c1);
            team.RemoveMembers(c1);

            Assert.AreEqual("c1", team.Members[0].Name);
        }
    }
}
