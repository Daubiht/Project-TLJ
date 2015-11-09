using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame
{
    [Serializable]
    public class Team
    {
        string _name;
        int _maxMembers = 4;
        int _currentNumMembers = 0;
        Invent _inventTeam;
        readonly List<Character> _membersList = new List<Character>();

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>

        public Team(string name, Character mainCharacter)
        {
            _name = name;
            _membersList.Add(mainCharacter);
            _inventTeam = new Invent(this);
            _currentNumMembers += 1;
        }

        /// <summary>
        /// METHODES
        /// </summary>

        // Add members
        public void AddMembers(Character MemberToAdd)
        {
            if (_membersList.Count < _maxMembers)
            { 
                _membersList.Add(MemberToAdd);
                _currentNumMembers += 1;
            }
        }

        // Remove members
        public void RemoveMembers(Character MemberToRemove)
        {
            // Verify if the member to remove is in the team
            if (_membersList.Contains(MemberToRemove)){
                _membersList.Remove(MemberToRemove);
                _currentNumMembers -= 1;
            }
        }

        // Change the position of the member
        public void ChangePositionMember(Character ConcernedMember, bool IsFront)
        {
            ConcernedMember.FrontPosition = IsFront;
        }

        // Get the position of the member
        public bool GetPosition(Character c)
        {
            return c.FrontPosition;
        }

        /// <summary>
        /// PROPERTIES
        /// </summary>

        public string Name
        {
            get { return _name; }
        }

        public int MaxMembers
        {
            get { return _maxMembers; }
        }

        public Invent Invent
        {
            get { return _inventTeam; }
        }

        public List<Character> Members
        {
            get { return _membersList; }
        }

        public int NumOfMembersInTeam
        {
            get { return _currentNumMembers; }
        }
    }
}
