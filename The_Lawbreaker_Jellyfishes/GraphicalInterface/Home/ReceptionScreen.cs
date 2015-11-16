using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicalInterface
{
    public partial class ReceptionScreen : UserControl
    {

        private MainForm _context;
           
        public ReceptionScreen(MainForm context)
        {
            InitializeComponent();
            _context = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateMainCharacter1 uc = new CreateMainCharacter1(_context);
            _context.ChangeUC(uc, false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadGame uc = new LoadGame(_context);
            _context.ChangeUC(uc, false);
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            _context.Close();
        }
    }
}
