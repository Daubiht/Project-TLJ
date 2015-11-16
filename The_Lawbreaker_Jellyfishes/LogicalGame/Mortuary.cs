using LogicalGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    public class Mortuary
    {
        int _numberBodyMax;
        int _numberBody;
        readonly List<Character> _bodyList;

        public Mortuary ()
        {
            _numberBodyMax = 10;
            _numberBody = 0;
            _bodyList = new List<Character>();

        }

        public bool DepositBody (Character c)
        {
            if (c.isAlive == true || _bodyList.Count >= _numberBodyMax || c.IsMain == true)
            {
                return false;
            }
            if (c.InTeam != null)
            {
                if (!c.InTeam.RemoveMembers(c))
                {
                    return false;
                }
            }
            _bodyList.Add(c);
            return true;
        }

        public bool takeBackBody(Character c, Team t)
        {
            // Si la team est full ALORS renvoit false
            //SINON renvoit vrai et ajoute le mec à la team

            if (!_bodyList.Contains(c) || t.Members.Count >= 4) 
            {
                return false;
            }

            t.AddMembers(c);
            _bodyList.Remove(c);
            return true;
        }

        public List<Character> BodyList
        {
            get { return _bodyList; }
        }
    }
}
