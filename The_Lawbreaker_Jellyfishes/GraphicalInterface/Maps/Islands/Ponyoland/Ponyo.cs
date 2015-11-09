using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;
using GraphicalInterface;

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
            GraphicalInterface.Ponyoland uc = new GraphicalInterface.Ponyoland(_contextForm, _contextWorld);
            _contextForm.ChangeUC(uc);
        }

        private void Milice_Click(object sender, EventArgs e)
        {
            Militia uc = new Militia(_contextForm, _contextWorld);
            _contextForm.ChangeUC(uc);
        }
    }
}
