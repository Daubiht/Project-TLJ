using LogicalGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicalInterface
{
    public partial class DeadMenList : Form
    {
        Team _team;
        Character _caster;
        Item _item;

        public DeadMenList(Team team, Character caster, Item itemToUse)
        {
            _team = team;
            _caster = caster;
            _item = itemToUse;

            InitializeComponent();
        }

        private void DeadMenList_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach  (Character chara in _team.Members)
            {
                if (!chara.isAlive)
                {
                    DeadMan deadMan = new DeadMan(chara, _caster, _item);
                    Controls.Add(deadMan);
                    deadMan.Top = i * (deadMan.Height + 10);
                    i++;
                }
            }
            if (i == 0)
            {
                Label rien = new Label();
                rien.Text = "Personne n'est mort. Pas encore.";
                rien.AutoSize = true;
                Controls.Add(rien);
            }
        }
    }
}
