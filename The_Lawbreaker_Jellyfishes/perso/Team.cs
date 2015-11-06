using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ITI.TLJ.perso;

namespace LogicalGame
{
    [Serializable]
    public class Team
    {
        string _name;
        int _maxMembers = 4;
        Invent _inventTeam;
        readonly Dictionary<Character, string> _membersList = new Dictionary<Character, string>();

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>

        public Team(string name, Character mainCharacter)
        {
            _name = name;
            _membersList.Add(mainCharacter, mainCharacter.Name);
            _inventTeam = new Invent(this);
        }

        /// <summary>
        /// METHODES
        /// </summary>

        // Add members
        public void AddMembers(Character MemberToAdd)
        {
            if (_membersList.Count < _maxMembers)
                _membersList.Add(MemberToAdd, MemberToAdd.Name);
        }

        // Remove members
        public void RemoveMembers(Character MemberToRemove)
        {
            _membersList.Remove(MemberToRemove);
        }

        // Change the position of the member
        public void ChangePositionMember(Character ConcernedMember, bool IsFront)
        {
            ConcernedMember.FrontPosition = IsFront;
        }

        // Get the position of the member
        //public bool GetPosition(Member M)
        //{
        //    M.FrontPosition;
        //}


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

        public Dictionary<Character, string> MemberList
        {
            get { return _membersList; }
        }
    }
}
