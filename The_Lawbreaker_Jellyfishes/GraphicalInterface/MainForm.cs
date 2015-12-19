using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;
using System.Runtime.InteropServices;

namespace GraphicalInterface
{
    public partial class MainForm : Form
    {
        MapWorld _w;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public MainForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

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
            for (int i = 0; i <Controls.Count; i++)
            {
                UserControl uc = (UserControl)Controls[i];
                if (uc.Visible)
                {
                    Controls.Remove(uc);
                    i--;
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
