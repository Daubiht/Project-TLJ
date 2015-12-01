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
            labelCharName.Text = selectedMember.Name;
            this.Location = new Point(0, 400-this.Height);
        }
    }
}
