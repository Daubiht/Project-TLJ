using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class DeadMan : UserControl
    {
        Character _chara;
        Character _deadMan;
        Item _item;

        public DeadMan(Character deadMan, Character chara, Item item)
        {
            _chara = chara;
            _deadMan = deadMan;
            _item = item;

            InitializeComponent();
        }

        private void Resurection_Click(object sender, EventArgs e)
        {
            if (!_deadMan.isAlive)
            {
                _deadMan.isAlive = true;
                _deadMan.Heal((int)(Math.Round(_deadMan.MaxHealthPoint * 0.3)));
                _chara.HealthPoint = _chara.HealthPoint -((int)(Math.Round(_chara.MaxHealthPoint * 0.3)));
                if (_chara.InTeam.Invent.Inventory[_item] - 1 <= 0) _chara.InTeam.Invent.Inventory.Remove(_item);
                else _chara.InTeam.Invent.Inventory[_item]-- ;
            }

            ((Form)TopLevelControl).Close();
        }

        private void DeadMan_Load(object sender, EventArgs e)
        {
            LName.Text = _deadMan.Name;
            LLevel.Text = "Niveau " + _deadMan.Level.ToString();
        }
    }
}
