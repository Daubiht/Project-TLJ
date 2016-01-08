using System;
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
            _contextWorld = contextWorld;
            _contextForm = contextForm;
            InitializeComponent();

            List<Notification> listNotifs = contextWorld.Notifs.ListNotif;

            for(int i = 0; i < listNotifs.Count; i++) 
            {
                Label LabelNotif = new Label();
                LabelNotif.AutoSize = true;
                LabelNotif.Text = listNotifs[i].Date + " - " + listNotifs[i].Name + " - " + listNotifs[i].Description;
                LabelNotif.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 16);
                panel1.Controls.Add(LabelNotif);
                LabelNotif.Location = new System.Drawing.Point(Width / 2 - LabelNotif.Width / 2, i * LabelNotif.Height);
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            _contextForm.ExitMenu(this);
        }
    }
}
