﻿using System;
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
using System.Threading;
using System.Drawing.Text;

namespace GraphicalInterface
{
    public partial class MainForm : Form
    {
        MapWorld _w;
        PrivateFontCollection _font = new PrivateFontCollection();

        public MainForm()
        {
            InitializeComponent();
            _font.AddFontFile("../../../Ressources/Neverwinter.otf");
            _font.AddFontFile("../../../Ressources/BLKCHCRY.ttf");

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            ReceptionScreen uc = new ReceptionScreen(this);
            ChangeUC(uc, false);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
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

        public PrivateFontCollection Font
        {
            get { return _font; }
        }

        public MapWorld world
        {
            get { return _w; }
            set { _w = value; }
        }
    }
}
