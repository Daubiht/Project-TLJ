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
    public partial class skillsForm : Form
    {
        public skillsForm()
        {
            SkillTree st = new SkillTree();
            Controls.Add(st);
            InitializeComponent();
        }

        private void skillsForm_Load(object sender, EventArgs e)
        {

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
