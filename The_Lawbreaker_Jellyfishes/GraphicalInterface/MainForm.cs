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

            LoadGame uc = new LoadGame(this);
            Controls.Add(uc);
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

        public void ToMenu(UserControl UCM)
        {
            foreach (UserControl uc in Controls)
            {
                uc.Visible = false;
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
