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
using System.Threading;
using System.Drawing.Text;

namespace GraphicalInterface
{
    public partial class MainForm : Form
    {
        PrivateFontCollection _font = new PrivateFontCollection();

        public MainForm()
        {
            InitializeComponent();
            _font.AddFontFile("../../../Ressources/Neverwinter.otf");
            _font.AddFontFile("../../../Ressources/Pieces of Eight.ttf");
            Controller ctrler = new Controller(this);
            ctrler.ToHome();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
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

        public PrivateFontCollection FormFont
        {
            get { return _font; }
        }
    }
}
