using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    public class Team
    {
        string _name;
        int _maxMembers = 4;
        Invent _inventTeam;

        readonly Dictionary<Member, string> _membersList = new Dictionary<Member, string>();

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>

        public Team(string name, Member mainCharacter)
        {
            _name = name;
            _membersList.Add(mainCharacter, mainCharacter.Name);
            _inventTeam = new Invent();
        }

        /// <summary>
        /// METHODES
        /// </summary>

        // Add members
        public void AddMembers(Member MemberToAdd)
        {
            if (_membersList.Count < _maxMembers)
                _membersList.Add(MemberToAdd, MemberToAdd.Name);
        }

        // Remove members
        public void RemoveMembers(Member MemberToRemove)
        {
            _membersList.Remove(MemberToRemove.Name);
        }

        // Change the position of the member
        public void ChangePositionMember(Member ConcernedMember, bool IsFront)
        {
            ConcernedMember.FrontPostion = IsFront;
        }

        // Get the position of the member
        public bool GetPosition(Member M)
        {
            return M.FrontPosition;
        }

        public Invent Inventory
        {
            get { return _inventTeam; }
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
    }
}
