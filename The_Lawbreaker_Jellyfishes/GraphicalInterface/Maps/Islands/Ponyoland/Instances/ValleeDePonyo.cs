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
    public partial class ValleeDePonyo : UserControl
    {
        MainForm _contextForm;
        MapWorld _contextWorld;

        public ValleeDePonyo(MainForm contextForm, MapWorld contextWorld)
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
    }
}
