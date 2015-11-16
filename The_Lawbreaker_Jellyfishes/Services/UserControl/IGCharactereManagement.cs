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
        int[] statsUped = new int[] { 0, 0, 0, 0, 0, 0 };
        int statPoint;

        public IGCharactereManagement(Character chara, Team team)
        {
            c = chara;
            t = team;
            statPoint = c.StatsPoint;

            InitializeComponent();
        }

        private void IGCharactereManagement_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 250;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            LLevel.Text = "Niveau " + c.Level;
            LXP.Text = c.CurentXp + " / " + c.NextLevel;
            LName.Text = c.Name;
            LHealth.Text = c.Health.ToString();
            LStamina.Text = c.Stamina.ToString();
            LRobustness.Text = c.Robustness.ToString();
            LDodge.Text = c.Dodge.ToString();
            LPhysical.Text = c.PhysicalAttack.ToString();
            LMagic.Text = c.MagicAttack.ToString();

            if ( c.StatsPoint > 0)
            {
                PPlus.Visible = true;
                LStatPoint.Visible = true;
                LStatPoint.Text = c.StatsPoint + " Point(s)";
            }

            if (c.Stuffs.ContainsKey("arme") && c.Stuffs["arme"] != null) toolTip.SetToolTip(Gauche, c.Stuffs["arme"].GetName);
            if (c.Stuffs.ContainsKey("arme") && c.Stuffs["arme"] != null) toolTip.SetToolTip(Droite, c.Stuffs["arme"].GetName);
            if (c.Stuffs.ContainsKey("bijou") && c.Stuffs["bijou"] != null) toolTip.SetToolTip(Cou, c.Stuffs["bijou"].GetName);
            if (c.Stuffs.ContainsKey("jambes") && c.Stuffs["jambes"] != null) toolTip.SetToolTip(Jambes, c.Stuffs["jambes"].GetName);
            if (c.Stuffs.ContainsKey("corps") && c.Stuffs["corps"] != null) toolTip.SetToolTip(Corps, c.Stuffs["corps"].GetName);
            if (c.Stuffs.ContainsKey("tete") && c.Stuffs["tete"] != null) toolTip.SetToolTip(Tete, c.Stuffs["tete"].GetName);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int stat = int.Parse((string)button.Tag);

            statsUped[stat]--;

            if (c.StatsPoint > 0)
            {
                PPlus.Visible = true;
            }

            switch (stat)
            {
                case 0:
                    if (statsUped[stat] == 0)
                    BHM.Visible = false;
                    break;
                case 1:
                    if (statsUped[stat] == 0)
                    BRM.Visible = false;
                    break;
                case 2:
                    if (statsUped[stat] == 0)
                    BSM.Visible = false;
                    break;
                case 3:
                    if (statsUped[stat] == 0)
                    BDM.Visible = false;
                    break;
                case 4:
                    if (statsUped[stat] == 0)
                    BAPM.Visible = false;
                    break;
                case 5:
                    if (statsUped[stat] == 0)
                    BAMM.Visible = false;
                    break;
            }

            statPoint++;

            LHealth.Text = (c.Stats[0] + statsUped[0]).ToString();
            LRobustness.Text = (c.Stats[1] + statsUped[1]).ToString();
            LStamina.Text = (c.Stats[2] + statsUped[2]).ToString();
            LDodge.Text = (c.Stats[3] + statsUped[3]).ToString();
            LPhysical.Text = (c.Stats[4] + statsUped[4]).ToString();
            LMagic.Text = (c.Stats[5] + statsUped[5]).ToString();
            LStatPoint.Text = statPoint.ToString();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int stat = int.Parse((string)button.Tag);

            statsUped[stat]++;

            switch (stat)
            {
                case 0:
                    BHM.Visible = true;
                    break;
                case 1:
                    BRM.Visible = true;
                    break;
                case 2:
                    BSM.Visible = true;
                    break;
                case 3:
                    BDM.Visible = true;
                    break;
                case 4:
                    BAPM.Visible = true;
                    break;
                case 5:
                    BAMM.Visible = true;
                    break;
            }

            statPoint--;

            if (statPoint == 0)
            {
                PPlus.Visible = false;
            }

            LHealth.Text = (c.Stats[0] + statsUped[0]).ToString();
            LRobustness.Text = (c.Stats[1] + statsUped[1]).ToString();
            LStamina.Text = (c.Stats[2] + statsUped[2]).ToString();
            LDodge.Text = (c.Stats[3] + statsUped[3]).ToString();
            LPhysical.Text = (c.Stats[4] + statsUped[4]).ToString();
            LMagic.Text = (c.Stats[5] + statsUped[5]).ToString();
            LStatPoint.Text = statPoint.ToString();
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            IGTeamManagement tm = new IGTeamManagement(t);
            Control parent = Parent;
            parent.Controls.Clear();
            parent.Controls.Add(tm);

            if (statsUped != new int[] { 0,0,0,0,0,0})
            {
                c.StatsUp(statsUped[4], statsUped[5], statsUped[0], statsUped[1], statsUped[2], statsUped[3]);
            }
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
            Stuffs("arme");
        }

        private void Droite_Click(object sender, EventArgs e)
        {
            Stuffs("arme");
        }

        private void Tete_Click(object sender, EventArgs e)
        {
            Stuffs("tete");
        }

        private void Bijou_Click(object sender, EventArgs e)
        {
            Stuffs("bijou");
        }

        private void Jambes_Click(object sender, EventArgs e)
        {
            Stuffs("jambes");
        }

        private void Corps_Click(object sender, EventArgs e)
        {
            Stuffs("corps");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stuffs("consommable");
        }
    }
}
