using System;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Ponyoland : UserControl
    {
        readonly MainForm _contextForm;
        readonly MapWorld _contextWorld;

        public Ponyoland(MainForm contextForm, MapWorld contextWorld)
        {
            InitializeComponent();
            _contextForm = contextForm;
            _contextWorld = contextWorld;
        }

        private void ValleeDePonyo_Click(object sender, EventArgs e)
        {
            ValleeDePonyo uc = new ValleeDePonyo(_contextForm, _contextWorld);
            _contextForm.ChangeUC(uc, true);
        }

        private void Ponyo_Click(object sender, EventArgs e)
        {
            Ponyo uc = new Ponyo(_contextForm, _contextWorld);
            _contextForm.ChangeUC(uc, true);
        }

        private void ForetDePonyo_Click(object sender, EventArgs e)
        {
            ForetDePonyo uc = new ForetDePonyo(_contextForm, _contextWorld);
            _contextForm.ChangeUC(uc, true);
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            World uc = new World(_contextWorld, _contextForm, false);
            _contextForm.ChangeUC(uc, true);
        }
    }
}
