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
    public partial class SkillsDisplay : UserControl
    {
        Character _chara;

        public SkillsDisplay(Character chara)
        {
            _chara = chara;

            InitializeComponent();
        }

        public Label SkillPoint
        {
            get { return LSkillPoint; }
        }

        private void SkillTree_Load(object sender, EventArgs e)
        {
            SkillsTab.SelectedTab.Controls.Clear();
            SkillsTab.SelectedTab.Controls.Add(new SkillsTree(int.Parse((string)SkillsTab.SelectedTab.Tag), _chara));
        }

        private void SkillsTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillsTab.SelectedTab.Controls.Clear();
            SkillsTab.SelectedTab.Controls.Add(new SkillsTree(int.Parse((string)SkillsTab.SelectedTab.Tag), _chara));
        }
    }
}
