﻿using System;
using System.IO;
using System.Windows.Forms;
using LogicalGame;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GraphicalInterface
{
    public partial class LoadGame : UserControl
    {
        Controller _ctrler;
        public LoadGame(Controller ctrler)
        {
            _ctrler = ctrler;
            InitializeComponent();
            Button[] listSlot = {slot1, slot2, slot3, slot4, slot5};
            string[] fileName = Directory.GetFiles(@"../../../Saves");

            for (int i = 0; i < fileName.Length; i++)
            {
                fileName[i] = fileName[i].Substring(15);
                listSlot[(int)Char.GetNumericValue(fileName[i][0]) - 1].Text = fileName[i].Substring(0, fileName[i].Length - 5);
                listSlot[(int)Char.GetNumericValue(fileName[i][0]) - 1].Enabled = true;
            }
        }

        private void ChooseGame(object slot, EventArgs e)
        {
            MapWorld w;
            string path = "";

            IFormatter formatter = new BinaryFormatter();

            string[] fileName = Directory.GetFiles(@"../../../Saves");
            foreach (string file in fileName)
            {
                if ((int)Char.GetNumericValue(file[15]) == (int)Char.GetNumericValue(((Button)slot).Text[0]))
                {
                    path = file;
                }
            }

            using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                w = (MapWorld)formatter.Deserialize(stream);
            }

            _ctrler.ToWorld(w, false);
            w.TavernCharactersChange();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            _ctrler.ToHome();
        }
    }
}
