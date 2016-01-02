using System;
using System.Windows.Forms;
using LogicalGame;
namespace GraphicalInterface
{
    public partial class Menu : UserControl
    {
        MapWorld _contextWorld;
        Controller _ctrler;

        public Menu(MapWorld contextWorld, Controller ctrler)
        {
            InitializeComponent();
            _contextWorld = contextWorld;
            _ctrler = ctrler;
        }

        private void equipe_Click(object sender, EventArgs e)
        {
            _ctrler.ToTeam(_contextWorld.Team, true);
        }

        private void inventaire_Click(object sender, EventArgs e)
        {
            _ctrler.ToInventory(_contextWorld.Team.Invent);
        }

        private void notifications_Click(object sender, EventArgs e)
        {
            _ctrler.ToNotif();
        }

        private void sauvegarde_Click(object sender, EventArgs e)
        {
            _ctrler.ToSave();
        }
    }
}
