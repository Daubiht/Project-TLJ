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
    public partial class CharacterInformations : UserControl
    {
        Character c;
        Team t;
        Controller _ctrler;
        int[] statsUped = new int[] { 0, 0, 0, 0, 0, 0 };
        int statPoint;

        public CharacterInformations(Character chara, Team team, Controller ctrler)
        {
            t = team;
            c = chara;
            _ctrler = ctrler;
            statPoint = c.StatsPoint;

            InitializeComponent();
        }

        private void IGCharactereManagement_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 250;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            LRace.Text = c.Race;
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
            LogicalGame.Taverne service = new LogicalGame.Taverne();
            _ctrler.ToService(service);
        }
        private void BSkills_Click(object sender, EventArgs e)
        {
            skillsForm skillsform = new skillsForm(c);
            skillsform.ShowDialog();
        }
    }
}
