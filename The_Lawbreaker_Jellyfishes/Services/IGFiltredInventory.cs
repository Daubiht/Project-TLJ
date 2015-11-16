using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace Services
{
    public partial class IGFiltredInventory : UserControl
    {
        Team t;
        Character c;

        public IGFiltredInventory(Team team, Character chara, string type)
        {
            t = team;
            c = chara;

            InitializeComponent();
        }

        private void BRetour_Click(object sender, EventArgs e)
        {
            IGCharactereManagement cm = new IGCharactereManagement(c, t);
            Control parent = Parent;
            parent.Controls.Clear();
            parent.Controls.Add(cm);
        }
    }
}
