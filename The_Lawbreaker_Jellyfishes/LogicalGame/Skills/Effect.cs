using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    [Serializable]
    public class Effect
    {
        string _name;
        int _power;
        int _time;
        Character _caster;

        public Effect (string name, int power, int time, Character caster)
        {
            _time = time;
            _name = name;
            _power = power;
            _caster = caster;
        }

        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Power
        {
            get { return _power; }
            set { _power = value; }
        }

        public Character Caster
        {
            get { return _caster; }
            set { _caster = value; }
        }
    }
}
