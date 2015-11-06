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
            if (c.isAlive == true || _numberBody >= _numberBodyMax)
            {
                return false;
            }
            if (c.InTeam != null)
            {
                c.InTeam.RemoveMembers(c);
            }
            _bodyList.Add(c);
            return true;
        }

        public bool takeBackBody(Character c, Team t)
        {
            // Si la team est full ALORS renvoit false
            //SINON renvoit vrai et ajoute le mec à la team

            if (!_bodyList.Contains(c)) 
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
