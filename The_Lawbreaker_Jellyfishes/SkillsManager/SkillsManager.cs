using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkillsManager
{
    public partial class SkillsManager : Form
    {
        public SkillsManager()
        {
            InitializeComponent();
        }

        private void SkillsManager_Load(object sender, EventArgs e)
        {
            SkillsListe sl = new SkillsListe();

            Controls.Add(sl);
        }
    }
}
