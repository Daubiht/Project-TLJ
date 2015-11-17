using LogicalGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    [Serializable]
    public class Mortuary
    {
        int _numberBodyMax;
        int _numberBody;
        readonly List<Character> _bodyList;
        readonly MapCity _context;
        readonly Team _team;

        public Mortuary (MapCity context)
        {
            _numberBodyMax = 10;
            _numberBody = 0;
            _bodyList = new List<Character>();
            _context = context;
            if(context != null) { _team = context.ActualIsland.ActualWorld.Team; }
        }

        public bool DepositBody (Character c)
        {
            if (c.isAlive == true || _bodyList.Count >= _numberBodyMax || c.IsMain == true)
            {
                return false;
            }
            if (c.InTeam != null)
            {
                return !c.InTeam.RemoveMembers(c);
            }
            _bodyList.Add(c);
            return true;
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
