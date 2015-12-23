using System;
using System.Windows.Forms;
using LogicalGame;
using Services;

namespace GraphicalInterface
{
    public partial class Menu : UserControl
    {
        MapWorld _contextWorld;
        MainForm _contextForm;
        
        public Menu(MapWorld contextWorld, MainForm contextForm)
        {
            _contextWorld = contextWorld;
            _contextForm = contextForm;
            InitializeComponent();

            equipe.Location = new System.Drawing.Point((Width - (equipe.Width + inventaire.Width + notifications.Width + sauvegarde.Width)) / 5, 0);
            inventaire.Location = new System.Drawing.Point(((Width - (equipe.Width + inventaire.Width + notifications.Width + sauvegarde.Width)) / 5) + equipe.Right, 0);
            notifications.Location = new System.Drawing.Point(((Width - (equipe.Width + inventaire.Width + notifications.Width + sauvegarde.Width)) / 5) + inventaire.Right, 0);
            sauvegarde.Location = new System.Drawing.Point(((Width - (equipe.Width + inventaire.Width + notifications.Width + sauvegarde.Width)) / 5) + notifications.Right, 0);
        }

        private void equipe_Click(object sender, EventArgs e)
        {
            TeamManagement uc = new TeamManagement(_contextWorld.Team, _contextForm);
            _contextForm.ToMenu(uc, false);
        }

        private void inventaire_Click(object sender, EventArgs e)
        {
            Inventory uc = new Inventory(_contextForm, _contextWorld.Team.Invent);
            _contextForm.ToMenu(uc, false);
        }

        private void notifications_Click(object sender, EventArgs e)
        {
            Notifications uc = new Notifications(_contextWorld, _contextForm);
            _contextForm.ToMenu(uc, false);
        }

        private void sauvegarde_Click(object sender, EventArgs e)
        {
            Save uc = new Save(_contextWorld, _contextForm);
            _contextForm.ToMenu(uc, false);
        }
    }
}
