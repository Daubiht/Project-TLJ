using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TLJ.UI.Test
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void createMainCharacter11_Load(object sender, EventArgs e)
        {

        }

        public void ChangeController(Control controllerToAdd)
        {
            Controls.Clear();
            Controls.Add(controllerToAdd);
        }
    }
}
