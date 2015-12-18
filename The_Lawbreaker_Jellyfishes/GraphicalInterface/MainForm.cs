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
            BackColor = Color.Transparent;
            Bitmap bg = new Bitmap("../../../Ressources/bgv2.jpeg");
            BackgroundImage = bg;
            BackgroundImageLayout = ImageLayout.Stretch;

            ReceptionScreen uc = new ReceptionScreen(this);
            ChangeUC(uc, false);
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
