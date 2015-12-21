using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class Team
    {
        string _name;
        int _maxMembers = 4;
        Invent _inventTeam;
        readonly List<Character> _membersList = new List<Character>();
        MapWorld _world = new MapWorld();

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>

        public Team(string name, MapWorld world)
        {
            _world = world;
            _name = name;
            _inventTeam = new Invent(this);
        }

        /// <summary>
        /// METHODES
        /// </summary>

        public MapWorld World
        {
            get { return _world; }
            set { _world = value; }
        }

        // Add members
        public void AddMembers(Character MemberToAdd)
        {
            if (_membersList.Count < _maxMembers)
            {
                _membersList.Add(MemberToAdd);
                MemberToAdd.InTeam = this;
            }
        }

        // Remove members
        public bool RemoveMembers(Character MemberToRemove)
        {
            if (MemberToRemove.IsMain == false)
            {
                return _membersList.Remove(MemberToRemove);
            }
            return false;
        }

        // Change the position of the member
        public void ChangePositionMember(Character ConcernedMember, bool IsFront)
        {
            ConcernedMember.FrontPosition = IsFront;
        }

        // Get the position of the member
        public bool GetPosition(Character C)
        {
            return C.FrontPosition;
        }


        /// <summary>
        /// PROPERTIES
        /// </summary>

        public string Name
        {
            get { return _name; }
        }

        public Character MainCharacter
        {
            get
            {
                foreach (Character member in _membersList)
                {
                    if (member.IsMain)
                    {
                        return member;
                    }
                }
                throw new Exception();
            }
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

       
    }
}
