using System;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class ForetDePonyo : UserControl
    {
        MainForm _contextForm;
        MapWorld _contextWorld;
        Random _rand;

        public ForetDePonyo(MainForm contextForm, MapWorld contextWorld)
        {
            InitializeComponent();
            _contextForm = contextForm;
            _contextWorld = contextWorld;
            _rand = _contextWorld.Random;
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Ponyoland uc = new Ponyoland(_contextForm, _contextWorld);
            _contextForm.ChangeUC(uc, true);
        }

        private void ForetDePonyo_Load(object sender, EventArgs e)
        {

        }
    }
}
