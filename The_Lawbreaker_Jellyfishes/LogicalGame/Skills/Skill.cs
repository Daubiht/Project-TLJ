using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame
{
    [Serializable]
    public class Skill
    {
        string _name;
        int[] _statRequired;
        int[][] _effect;
        int _position;
        int _target;
        int[] _cost;

        Skill _previousSkill;
        Skill _nextSkill;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="statRequired"></param>
        /// <param name="target">0 Sois même, 1 Allié, 2 Enemie</param>
        /// <param name="position">0 Toute || 1 CaC || 2 Po </param>
        /// <param name="effect"></param>
        /// <param name="cost">0 Health || 1 Stamina</param>
        public Skill (string name, int[] statRequired, int target, int position, int[][] effect, int[] cost)
        {
            _name = name;
            _statRequired = statRequired;
            _target = target;
            _effect = effect;
            _position = position;
            _cost = cost;
            _previousSkill = null;
            _nextSkill = null;
        }

        

        public string Name
        {
            get { return _name; }
        }

        public int[] statRequired
        {
            get { return _statRequired; }
        }

        public int[][] Effect
        {
            get { return _effect; }
        }

        public int Target
        {
            get { return _target; }
        }

        public int Position
        {
            get { return _position; }
        }

        public int[] Cost
        {
            get { return _cost; }
        }

        public Skill PreviousSkill
        {
            get { return _previousSkill; }
            set { _previousSkill = value; }
        }

        public Skill nextSkill
        {
            get { return _nextSkill; }
            set { _nextSkill = value; }
        }
    }
}
