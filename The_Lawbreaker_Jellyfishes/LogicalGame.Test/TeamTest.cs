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
            Character character = new Character("Character1", "Geant", false);
            Team team = new Team("Team1", character);

            Assert.AreEqual("Team1", team.Name);
            Assert.AreEqual(character, team.Members[0]);
        }

        [Test]
        public void Test_to_add_members_in_the_team()
        {
            // Create a team with a main character "MainCharacter"
            Character mainCharacter = new Character("MainCharacter", "Geant", false);
            Team team = new Team("Team1", mainCharacter);

            // Create an other character "memberToAdd"
            Character memberToAdd = new Character("memberAdded", "Geant", false);

            // Add "c1" in the team
            team.AddMembers(memberToAdd);

            Assert.AreEqual(memberToAdd, team.Members[1]);

            // Verify the counter of number of the team
            Assert.AreEqual(2, team.NumOfMembersInTeam);
        }
        [Test]
        public void Test_to_remove_members_in_the_team()
        {
            // Create a team with a main character
            Character character = new Character("Character1", "Geant", false);
            Team team = new Team("Team1", character);

            // Add an other member "c1"
            Character c1 = new Character("Name1", "Geant", false);
            team.AddMembers(c1);

            // Remove the member "c1"
            team.RemoveMembers(c1);
            Assert.AreEqual(1, team.Members.Count);

            // Verify the counter of number of the team
            Assert.AreEqual(1, team.NumOfMembersInTeam);

        }

        [Test]
        public void Test_to_change_the_position_of_a_character()
        {
            // Create a team with a main character and the positon "False"
            Character character = new Character("Character1", "Geant", false);
            Team team = new Team("Team1", character);

            // Change the position of the main character with "True"
            team.ChangePositionMember(character, true);

            Assert.AreEqual(true, team.Members[0].FrontPosition);
        }
    }
}
