using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface.Fighting
{
    public partial class FightMenu : UserControl
    {
        public FightMenu(Character selectedMember)
        {
            InitializeComponent();
            // Display the name of the character
            labelCharName.Text = selectedMember.Name;
            // Set the X and Y location of the fight menu
            Location = new Point(0, 440-Height);
            // By default an arrow is displayd near the toolstrip, here we hide the arrows
            toolStripSkills.ShowDropDownArrow = false;
            toolStripInventory.ShowDropDownArrow = false;
            // We set the value of the HP BAR
            progressBar1.Maximum = selectedMember.MaxHealthPoint;
            progressBar1.Value = selectedMember.HealthPoint;
        }
    }
}
