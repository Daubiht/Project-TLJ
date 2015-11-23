using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IGMapEditor;

namespace IGMapEditor
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MapEditor.button = 0;
        }

        private void BInstance_Click(object sender, EventArgs e)
        {
            MapEditor.button = 1;
        }

        private void BCity_Click(object sender, EventArgs e)
        {
            MapEditor.button = 2;
        }

        private void BServ_Click(object sender, EventArgs e)
        {
            MapEditor.button = 3;
        }

        private void BLink_Click(object sender, EventArgs e)
        {
            MapEditor.button = 4;
        }

        public void City_click (object sender, EventArgs e)
        {

        }
    }
}
