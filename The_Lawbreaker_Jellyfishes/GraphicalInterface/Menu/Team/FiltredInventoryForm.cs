using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicalInterface
{
    public partial class FiltredInventoryForm : Form
    {
        public FiltredInventoryForm(UserControl uc)
        {
            InitializeComponent();
            Controls.Add(uc);
        }
    }
}
