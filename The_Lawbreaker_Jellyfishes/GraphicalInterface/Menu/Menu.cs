using System;
using System.Windows.Forms;
using LogicalGame;
namespace GraphicalInterface
{
    public partial class Menu : UserControl
    {
        MapWorld _ctrlerWorld;
        Controller _ctrler;
        
        public Menu(MapWorld contextWorld, Controller ctrler)
        {
            _ctrlerWorld = contextWorld;
            _ctrler = ctrler;
            InitializeComponent();

            equipe.Location = new System.Drawing.Point((Width - (equipe.Width + inventaire.Width + notifications.Width + sauvegarde.Width)) / 5, 0);
            inventaire.Location = new System.Drawing.Point(((Width - (equipe.Width + inventaire.Width + notifications.Width + sauvegarde.Width)) / 5) + equipe.Right, 0);
            notifications.Location = new System.Drawing.Point(((Width - (equipe.Width + inventaire.Width + notifications.Width + sauvegarde.Width)) / 5) + inventaire.Right, 0);
            sauvegarde.Location = new System.Drawing.Point(((Width - (equipe.Width + inventaire.Width + notifications.Width + sauvegarde.Width)) / 5) + notifications.Right, 0);
        }

        private void equipe_Click(object sender, EventArgs e)
        {
            _ctrler.ToTeam(_ctrlerWorld.Team, true);
        }

        private void inventaire_Click(object sender, EventArgs e)
        {
            _ctrler.ToInventory(_ctrlerWorld.Team.Invent);
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
