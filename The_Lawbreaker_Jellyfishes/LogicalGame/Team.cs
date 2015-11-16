﻿using System;
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
        readonly List<Character> _membersList = new List<Character>();

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>

        public Team(string name, Character mainCharacter)
        {
            mainCharacter.InTeam = this;
            _name = name;
            _membersList.Add(mainCharacter);
            _inventTeam = new Invent(this);
        }

        /// <summary>
        /// METHODES
        /// </summary>

        // Add members
        public void AddMembers(Character MemberToAdd)
        {
            if (_membersList.Count < _maxMembers)
            {
                MemberToAdd.InTeam = this;
                _membersList.Add(MemberToAdd);
                MemberToAdd.InTeam = this;
            }
        }

        // Remove members
        public bool RemoveMembers(Character MemberToRemove)
        {
            if (!_membersList.Contains(MemberToRemove))
            {
                return false;
            }
            MemberToRemove.InTeam = null;
            _membersList.Remove(MemberToRemove);
            MemberToRemove.KickFromTeam();
            return true;
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

        public List<Character> Members
        {
            get { return _membersList; }
        }
    }
}
