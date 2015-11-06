using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITI.TLJ.perso
{
    public class Skill
    {
        string _name;
        public Skill (string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
