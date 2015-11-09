using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class LoadGame : UserControl
    {
        public LoadGame()
        {
            InitializeComponent();

            Button[] listSlot = {slot1, slot2, slot3, slot4, slot5};
            string[] fileName = Directory.GetFiles(@"../../../Saves");

            for (int i = 0; i < fileName.Length; i++)
            {
                fileName[i] = fileName[i].Substring(15);
                listSlot[(int)Char.GetNumericValue(fileName[i][0]) - 1].Text = fileName[i].Substring(0, fileName[i].Length - 5);
            }
        }

        private void slot1_Click(object sender, EventArgs e)
        {

        }
    }
}
