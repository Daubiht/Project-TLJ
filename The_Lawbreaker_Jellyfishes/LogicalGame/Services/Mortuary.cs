using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class Mortuary
    {
        int _numberBodyMax;
        readonly List<Character> _bodyList;
        readonly MapCity _context;
        readonly Team _team;
        int _x;
        int _y;

        public Mortuary (MapCity context)
        {
            _numberBodyMax = 4;
            _bodyList = new List<Character>();
            _context = context;
            if(context != null) { _team = context.ActualIsland.ActualWorld.Team; }
        }

        public bool DepositBody (Character c)
        {
            if (c.isAlive || _bodyList.Count >= _numberBodyMax || c.IsMain)
            {
                return false;
            }
            if (c.InTeam != null)
            {
                _bodyList.Add(c);
                return !c.InTeam.RemoveMembers(c);
            }
            else
            {
                _bodyList.Add(c);
            }

            return true;
        }

        public int PointX
        {
            get { return _x; }
            set { _x = value; }
        }

        public int PointY
        {
            get { return _y; }
            set { _y = value; }
        }

        public bool takeBackBody(Character c)
        {
            // Si la team est full ALORS renvoit false
            //SINON renvoit vrai et ajoute le mec à la team

            if (!_bodyList.Contains(c) || _team.Members.Count >= 4) 
            {
                return false;
            }

            _team.AddMembers(c);
            _bodyList.Remove(c);
            return true;
        }

        public List<Character> BodyList
        {
            get { return _bodyList; }
        }
    }
}
