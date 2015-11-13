using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Menu : UserControl
    {
        MapWorld _contextWorld;
        MainForm _contextForm;

        public Menu(MapWorld contextWorld, MainForm contextForm)
        {
            InitializeComponent();
            _contextWorld = contextWorld;
            _contextForm = contextForm;
        }

        private void equipe_Click(object sender, EventArgs e)
        {

        }

        private void inventaire_Click(object sender, EventArgs e)
        {
            Inventory uc = new Inventory(_contextForm, _contextWorld);
            _contextForm.ToMenu(uc);
        }

        private void notifications_Click(object sender, EventArgs e)
        {
            Notifications uc = new Notifications(_contextWorld, _contextForm);
            _contextForm.ToMenu(uc);
        }

        private void sauvegarde_Click(object sender, EventArgs e)
        {
            Save uc = new Save(_contextWorld, _contextForm);
            _contextForm.ToMenu(uc);
        }
    }
}
