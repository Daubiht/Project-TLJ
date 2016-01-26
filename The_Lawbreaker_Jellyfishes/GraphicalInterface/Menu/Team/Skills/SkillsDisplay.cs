using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;
using System.Drawing.Text;

namespace GraphicalInterface
{
    public partial class SkillsDisplay : UserControl
    {
        Character _chara;
        PrivateFontCollection _font;

        public SkillsDisplay(Character chara, PrivateFontCollection font)
        {
            _chara = chara;
            _font = font;

            InitializeComponent();
        }

        public Label SkillPoint
        {
            get { return LSkillPoint; }
        }

        private void SkillTree_Load(object sender, EventArgs e)
        {
            PSkills.Controls.Clear();
            PSkills.Controls.Add(new SkillsTree(0, _chara, this, _font));
        }

        private void SkillsTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int stat = int.Parse((string)button.Tag);
            PSkills.Controls.Clear();
            PSkills.Controls.Add(new SkillsTree(stat, _chara, this, _font));
        }
    }
}
