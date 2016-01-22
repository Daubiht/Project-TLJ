using System;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Militia : UserControl
    {
        Controller _ctrler;
        MapWorld _ctrlerWorld;

        public Militia(Controller ctrler, MapWorld contextWorld)
        {
            _ctrlerWorld = contextWorld;
            _ctrler = ctrler;
            InitializeComponent();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            _ctrler.ExitMenu(this);
        }

        private void Utilise_Click(object sender, EventArgs e)
        {
            _ctrler.ToWorld(_ctrlerWorld, true);
        }
    }
}