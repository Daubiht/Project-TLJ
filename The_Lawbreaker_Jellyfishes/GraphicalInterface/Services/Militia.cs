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
    public partial class Militia : UserControl
    {
        MainForm _contextForm;
        MapWorld _contextWorld;

        public Militia(MainForm contextForm, MapWorld contextWorld)
        {
            InitializeComponent();
            _contextWorld = contextWorld;
            _contextForm = contextForm;
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Ponyo uc = new Ponyo(_contextForm, _contextWorld);
            _contextForm.ChangeUC(uc, true);
        }

        private void Utilise_Click(object sender, EventArgs e)
        {
            World uc = new World(_contextWorld, _contextForm, true);
            _contextForm.ChangeUC(uc, true);
        }
    }
}
