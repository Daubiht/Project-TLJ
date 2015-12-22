using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicalInterface
{
    public partial class ReceptionScreen : UserControl
    {

        internal MainForm _context;
           
        public ReceptionScreen(MainForm context)
        {
            _context = context;
            InitializeComponent();

            quitButton.Location = new Point(Width / 2 - quitButton.Width / 2, 250);
            ChargeParty.Location = new Point(Width / 2 - ChargeParty.Width / 2, 150);
            NewParty.Location = new Point(Width / 2 - NewParty.Width / 2, 50);
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
