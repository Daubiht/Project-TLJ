using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Notifications : UserControl
    {
        MapWorld _ctrlerWorld;
        Controller _ctrler;

        public Notifications(MapWorld contextWorld, Controller ctrler)
        {
            _ctrlerWorld = contextWorld;
            _ctrler = ctrler;
            InitializeComponent();

            List<Notification> listNotifs = contextWorld.Notifs.ListNotif;

            if(listNotifs.Count == 0)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Text = "Vous n'avez aucune notification.";
                label.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 20);
                panel1.Controls.Add(label);
                label.Location = new System.Drawing.Point(Width / 2 - label.Width / 2, label.Height);
            }
            else
            {

                for (int i = 0; i < listNotifs.Count; i++)
                {
                    Label LabelNotif = new Label();
                    LabelNotif.AutoSize = true;
                    LabelNotif.Text = listNotifs[i].Date + " - " + listNotifs[i].Name + " - " + listNotifs[i].Description;
                    LabelNotif.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 16);
                    panel1.Controls.Add(LabelNotif);
                    LabelNotif.Location = new System.Drawing.Point(Width / 2 - LabelNotif.Width / 2, i * LabelNotif.Height);
                }
            }

        }

        private void retour_Click(object sender, EventArgs e)
        {
            _ctrler.ExitMenu(this);
        }
    }
}
