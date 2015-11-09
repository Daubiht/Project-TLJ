using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using LogicalGame;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GraphicalInterface
{
    public partial class LoadGame : UserControl
    {
        MainForm _contextForm;
        public LoadGame(MainForm contextForm)
        {
            InitializeComponent();
            _contextForm = contextForm;
            Button[] listSlot = {slot1, slot2, slot3, slot4, slot5};
            string[] fileName = Directory.GetFiles(@"../../../Saves");

            for (int i = 0; i < fileName.Length; i++)
            {
                fileName[i] = fileName[i].Substring(15);
                listSlot[(int)Char.GetNumericValue(fileName[i][0]) - 1].Text = fileName[i].Substring(0, fileName[i].Length - 5);
                listSlot[(int)Char.GetNumericValue(fileName[i][0]) - 1].Enabled = true;
            }
        }

        private void ChooseGame(Button slot)
        {
            MapWorld w;
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Saves/" + slot.Text + ".save", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                w = (MapWorld)formatter.Deserialize(stream);
            }

            _contextForm.world = w;
            World uc = new World(w, _contextForm, false);
            _contextForm.ChangeUC(uc, true);
        }

        private void slot1_Click(object sender, EventArgs e)
        {
            ChooseGame((Button)sender);
        }

        private void slot2_Click(object sender, EventArgs e)
        {
            ChooseGame((Button)sender);
        }

        private void slot3_Click(object sender, EventArgs e)
        {
            ChooseGame((Button)sender);
        }

        private void slot4_Click(object sender, EventArgs e)
        {
            ChooseGame((Button)sender);
        }

        private void slot5_Click(object sender, EventArgs e)
        {
            ChooseGame((Button)sender);
        }
    }
}
