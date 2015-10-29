using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    public class Monster
    {
        readonly string _name;
        readonly string _race;
        int _level;

        int _physicalAttack;
        int _magicAttack;
        int _health;
        int _stamina;
        int _dodge;
        int _robustness;

        int _healthPoint;
        int _staminaPoint;
        int _maxHealthPoint;
        int _maxStaminaPoint;

        bool _frontPosition;

        readonly Dictionary<String, Skill> _skills;
    }
}
