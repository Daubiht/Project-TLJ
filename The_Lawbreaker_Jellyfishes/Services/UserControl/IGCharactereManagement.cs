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
    public partial class IGCharactereManagement : UserControl
    {
        Character c;
        Team t;

        public IGCharactereManagement(Character chara, Team team)
        {
            c = chara;
            t = team;

            InitializeComponent();
        }

        private void IGCharactereManagement_Load(object sender, EventArgs e)
        {
            LLevel.Text = "Niveau " + c.Level;
            LXP.Text = c.CurentXp + " / " + c.NextLevel;
            LName.Text = c.Name;
            LHealth.Text = c.Health.ToString();
            LStamina.Text = c.Stamina.ToString();
            LRobustness.Text = c.Robustness.ToString();
            LDodge.Text = c.Dodge.ToString();
            LPhysical.Text = c.PhysicalAttack.ToString();
            LMagic.Text = c.MagicAttack.ToString();
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            IGTeamManagement tm = new IGTeamManagement(t);
            Control parent = Parent;
            parent.Controls.Clear();
            parent.Controls.Add(tm);
        }

        internal void Stuffs (string type)
        {
            IGFiltredInventory tm = new IGFiltredInventory(t, c, type);
            Control parent = Parent;
            parent.Controls.Clear();
            parent.Controls.Add(tm);
        }

        private void Gauche_Click(object sender, EventArgs e)
        {
            Stuffs("gauche");
        }

        private void Droite_Click(object sender, EventArgs e)
        {
            Stuffs("droite");
        }

        private void Tete_Click(object sender, EventArgs e)
        {
            Stuffs("tete");
        }

        private void Cou_Click(object sender, EventArgs e)
        {
            Stuffs("cou");
        }

        private void Jambes_Click(object sender, EventArgs e)
        {
            Stuffs("jambes");
        }

        private void Corps_Click(object sender, EventArgs e)
        {
            Stuffs("corps");
        }
    }
}
