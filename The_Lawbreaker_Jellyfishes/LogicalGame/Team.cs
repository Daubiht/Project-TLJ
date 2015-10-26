using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventory.FC;

namespace Team
{
    public class team
    {
        string _name;
        int _maxMembers = 4;

        readonly Dictionary<Member, string> _membersList = new Dictionary<Member, string>();

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>

        public team(string name, Member mainCharacter)
        {
            _name = name;
            _membersList.Add(mainCharacter, mainCharacter.Name);
            Invent _inventTeam = new Invent(this);
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
            M.FrontPosition;
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
