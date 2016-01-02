using System;
using System.Windows.Forms;

namespace GraphicalInterface
{
    public partial class ReceptionScreen : UserControl
    {

        private Controller _ctrler;
           
        public ReceptionScreen(Controller ctrler)
        {
            InitializeComponent();
            _ctrler = ctrler;
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
