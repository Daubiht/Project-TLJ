using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class MainForm : Form
    {
        MapWorld _w;
        public MainForm()
        {
            InitializeComponent();

            ReceptionScreen uc = new ReceptionScreen(this);
            ChangeUC(uc, false);
        }

        public void ChangeUC(UserControl UCI, bool Menu)
        {
            Controls.Clear();
            Controls.Add(UCI);
            if (Menu)
            {
                Menu UCM = new Menu(_w, this);
                Controls.Add(UCM);
            }
        }

        public void ChangeUC(UserControl UCI, bool Menu, bool multipleMenu)
        {
            foreach (UserControl uc in Controls)
            {
                if (uc.Visible)
                {
                    Controls.Clear();
                }
            }

            Controls.Add(UCI);
            if (Menu)
            {
                Menu UCM = new Menu(_w, this);
                Controls.Add(UCM);
            }
        }

        public void ToMenu(UserControl UCM, bool Menu)
        {
            foreach (UserControl uc in Controls)
            {
                if ((uc is Menu) && Menu)
                {
                    uc.Visible = true;
                }
                else
                {
                    uc.Visible = false;
                }
            }
            Controls.Add(UCM);
        }

        public void ExitMenu(UserControl ucm)
        {
            Controls.Remove(ucm);
            foreach (UserControl uc in Controls)
            {
                uc.Visible = true;
            }
        }

        public MapWorld world
        {
            get { return _w; }
            set { _w = value; }
        }
    }
}
