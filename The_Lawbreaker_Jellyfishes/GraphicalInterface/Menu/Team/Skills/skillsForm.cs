using LogicalGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicalInterface
{
    public partial class skillsForm : Form
    {
        PrivateFontCollection _font;
        public skillsForm(Character chara, PrivateFontCollection font)
        {
            _font = font;
            SkillsDisplay sd = new SkillsDisplay(chara, _font);
            Controls.Add(sd);
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void skillsForm_Leave(object sender, EventArgs e)
        {
            Close();
        }

        private void skillsForm_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}
