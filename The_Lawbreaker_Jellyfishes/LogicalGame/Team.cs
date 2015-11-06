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
        Invent _inventTeam;
        readonly List<Member> _membersList = new List<Member>();

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>

        public Team(string name, Member mainCharacter)
        {
            _name = name;
            _membersList.Add(mainCharacter);
            _inventTeam = new Invent(this);
        }

        /// <summary>
        /// METHODES
        /// </summary>

        // Add members
        public void AddMembers(Member MemberToAdd)
        {
            if (_membersList.Count < _maxMembers)
                _membersList.Add(MemberToAdd);
        }

        // Remove members
        public void RemoveMembers(Member MemberToRemove)
        {
            //_membersList.Remove(MemberToRemove.Name);
        }

        // Change the position of the member
        public void ChangePositionMember(Member ConcernedMember, bool IsFront)
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

        public List<Member> Members
        {
            get { return _membersList; }
        }
    }
}
