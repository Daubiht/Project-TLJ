using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicalInterface
{
    public partial class EndFightVictory : UserControl
    {
        MainForm _context;
        public EndFightVictory(MainForm Context)
        {
            InitializeComponent();
            _context = Context;
        }
    }
}
