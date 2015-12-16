using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IGMapEditor;
using MapEditor;

namespace IGMapEditor
{
    public partial class Menu : UserControl
    {
        Editor _context;

        public Menu(Editor context)
        {
            _context = context;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void City_click (object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Tool_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = (string)button.Tag;

            _context.Button = name;
        }
    }
}
