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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GraphicalInterface
{
    public partial class Save : UserControl
    {
        MainForm _contextForm;
        MapWorld _contextWorld;

        public Save(MapWorld contextWorld, MainForm contextForm)
        {
            InitializeComponent();
            _contextForm = contextForm;
            _contextWorld = contextWorld;

            RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5 };
            string[] fileName = Directory.GetFiles(@"../../../Saves");

            for (int i = 0; i < fileName.Length; i++)
            {
                fileName[i] = fileName[i].Substring(15);
                radioButtons[(int)Char.GetNumericValue(fileName[i][0]) - 1].Text = fileName[i].Substring(0, fileName[i].Length - 5);
                radioButtons[(int)Char.GetNumericValue(fileName[i][0]) - 1].Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (RadioButton btn in panel1.Controls.OfType<RadioButton>())
            {
                if (btn.Checked)
                {
                    _contextWorld.Save((int)Char.GetNumericValue(btn.Name[btn.Name.Length - 1]));
                }
            }

        }
    }
}
