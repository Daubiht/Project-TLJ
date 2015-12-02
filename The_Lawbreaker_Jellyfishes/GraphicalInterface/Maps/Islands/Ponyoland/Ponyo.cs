using System;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Ponyo : UserControl
    {
        readonly MainForm _contextForm;
        readonly MapWorld _contextWorld;

        public Ponyo(MainForm contextForm, MapWorld contextWorld)
        {
            InitializeComponent();
            _contextForm = contextForm;
            _contextWorld = contextWorld;
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Ponyoland uc = new Ponyoland(_contextForm, _contextWorld);
            _contextForm.ChangeUC(uc, true);
        }

        private void Milice_Click(object sender, EventArgs e)
        {
            Militia uc = new Militia(_contextForm, _contextWorld);
            _contextForm.ToMenu(uc, true);
        }

        private void Marchand_Click(object sender, EventArgs e)
        {
            Merchant uc = new Merchant(_contextForm, _contextWorld.Islands[_contextWorld.ActualIsland].IslandCity.Merchant[0], _contextWorld.Team.Invent);
            _contextForm.ToMenu(uc, true);
        }

        private void Morgue_Click(object sender, EventArgs e)
        {
            Mortuary uc = new Mortuary(_contextWorld.Team, _contextForm, _contextWorld.Islands[_contextWorld.ActualIsland].IslandCity.Mortuary);
            _contextForm.ToMenu(uc, true);
        }

        private void Taverne_Click(object sender, EventArgs e)
        {
            Taverne uc = new Taverne(_contextWorld.Team, _contextForm);
            _contextForm.ToMenu(uc, true);
        }
    }
}
