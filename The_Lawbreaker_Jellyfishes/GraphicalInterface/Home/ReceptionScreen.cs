using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicalInterface
{
    public partial class ReceptionScreen : UserControl
    {

        Controller _ctrler;
        Image _img;
           
        public ReceptionScreen(Controller ctrler)
        {
            _ctrler = ctrler;
            _img = Image.FromFile(@"../../../Ressources/tampon.png");
            InitializeComponent();

            quitButton.Location = new Point(Width / 2 - quitButton.Width / 2, 250);
            ChargeParty.Location = new Point(Width / 2 - ChargeParty.Width / 2, 150);
            NewParty.Location = new Point(Width / 2 - NewParty.Width / 2, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ctrler.ToCreateMainCharacter1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ctrler.ToLoadGame();
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            _ctrler.Quit();
        }
    }
}
