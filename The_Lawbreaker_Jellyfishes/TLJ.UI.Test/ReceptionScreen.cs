using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TLJ.UI.Test
{
    public partial class ReceptionScreen : UserControl
    {
        
        public ReceptionScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateMainCharacter1 cMC1 = new CreateMainCharacter1();
            Parent.Controls.Add(cMC1);
            Parent.Controls.Remove(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Leave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
