﻿using System;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Militia : UserControl
    {
        Controller _ctrler;
        MapWorld _contextWorld;

        public Militia(Controller ctrler, MapWorld contextWorld)
        {
            InitializeComponent();
            _contextWorld = contextWorld;
            _ctrler = ctrler;
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            _ctrler.ExitMenu(this);
        }

        private void Utilise_Click(object sender, EventArgs e)
        {
            _ctrler.ToWorld(_contextWorld, true);
        }
    }
}
