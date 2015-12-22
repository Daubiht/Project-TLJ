﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Notifications : UserControl
    {
        MapWorld _contextWorld;
        MainForm _contextForm;

        public Notifications(MapWorld contextWorld, MainForm contextForm)
        {
            InitializeComponent();
            _contextWorld = contextWorld;
            _contextForm = contextForm;

            List<Notification> listNotifs = contextWorld.Notifs.ListNotif;
            Label[] listLabels = {notif1, notif2, notif3, notif4, notif5, notif6, notif6, notif7, notif8, notif9, notif10};

            int max = contextWorld.Notifs.ListNotif.Count;

            for (int i = max; i > 0; i--)
            {
                listLabels[max - i].Text = listNotifs[i-1].Name + " - " + listNotifs[i-1].Description + " - " + listNotifs[i-1].Date;
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            _contextForm.ExitMenu(this);
        }
    }
}
